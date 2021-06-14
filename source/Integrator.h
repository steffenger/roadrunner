// == PREAMBLE ================================================

// * Licensed under the Apache License, Version 2.0; see README

// == FILEDOC =================================================

/** @file Integrator.h
* @author ETS, WBC, JKM
* @date Sep 7, 2013
* @copyright Apache License, Version 2.0
* @brief Contains the base class for RoadRunner integrators
**/

# ifndef RR_INTEGRATOR_H_
# define RR_INTEGRATOR_H_

// == INCLUDES ================================================

#include "rrLogger.h"
#include "rrOSSpecifics.h"
#include "Dictionary.h"
#include "rrException.h"
#include "Solver.h"

#include "tr1proxy/rr_memory.h"
#include "tr1proxy/rr_unordered_map.h"
#include "Registrar.h"
#include <stdexcept>

// == CODE ====================================================

namespace rr {

    class Integrator;

    class ExecutableModel;

    /*-------------------------------------------------------------------------------------------
        IntegratorListener listens for integrator events.
    ---------------------------------------------------------------------------------------------*/
    class IntegratorListener {
    public:

        /**
        * is called after the internal integrator completes each internal time step.
        */
        virtual uint onTimeStep(Integrator *integrator, ExecutableModel *model, double time) = 0;

        /**
        * whenever model event occurs and after it is procesed.
        */
        virtual uint onEvent(Integrator *integrator, ExecutableModel *model, double time) = 0;

        virtual ~IntegratorListener() {};
    };

    typedef cxx11_ns::shared_ptr<IntegratorListener> IntegratorListenerPtr;

    /*-------------------------------------------------------------------------------------------
        Integrator is an abstract base class that provides an interface to specific integrator
        class implementations.
    ---------------------------------------------------------------------------------------------*/
    class RR_DECLSPEC Integrator : public Solver {
    public:
        /**
        * Pull down the setValue from superclass.
        * We do not need to reimplement this
        * but we make it explicit.
        */
        using Solver::setValue;

        enum IntegrationMethod {
            Deterministic,
            Stochastic,
            Hybrid,
            Other
        };

        explicit Integrator(ExecutableModel* model);

        virtual ~Integrator() {};

        virtual IntegrationMethod getIntegrationMethod() const = 0;

        /**
        * @author JKM
        * @brief Called whenever a new model is loaded to allow integrator
        * to reset internal state
        */
        virtual void syncWithModel(ExecutableModel *m);

        virtual void loadConfigSettings();

        virtual void loadSBMLSettings(const std::string &filename);

        virtual double integrate(double t0, double hstep) = 0;

        virtual void restart(double t0) = 0;

        /**
         * @author JKM, WBC, ETS, MTK
         * @brief Fix tolerances for SBML tests
         * @details In order to ensure that the results of the SBML test suite
         * remain valid, this method enforces a lower bound on tolerance values.
         * Sets minimum absolute and relative tolerances to
         * Config::CVODE_MIN_ABSOLUTE and Config::CVODE_MIN_RELATIVE resp.
         */
        virtual void tweakTolerances();

        /**
        * @author FY
        * @brief Set tolerance for floating species or variables that have a rate rule, will only be used in CVODEIntegrator
        */
        virtual void setIndividualTolerance(std::string sid, double value);


        /**
        * @author FY
        * @brief Set tolerance based on concentration of species, will only be used in CVODEIntegrator
        */
        virtual void setConcentrationTolerance(Setting value);

        /**
        * @author FY
        * @brief Get tolerance based on concentration of species, will only be used in CVODEIntegrator
        */
        virtual std::vector<double> getConcentrationTolerance();


        /* CARRYOVER METHODS */
        virtual void setListener(IntegratorListenerPtr) = 0;

        virtual IntegratorListenerPtr getListener() = 0;

        std::string toString() const;

        /**
        * @author JKM
        * @brief Return std::string representation a la Python __repr__ method
        */
        virtual std::string toRepr() const;
        /* !-- END OF CARRYOVER METHODS */
    };


    class IntegratorException : public std::runtime_error {
    public:
        explicit IntegratorException(const std::string &what) :
                std::runtime_error(what) {
        }

        explicit IntegratorException(const std::string &what, const std::string &where) :
                std::runtime_error(what + "; In " + where) {
        }
    };

//    /**
//     * @author JKM, WBC
//     * @brief Handles constructing an integrator and contains meta
//     * information about it
//     */
//    class RR_DECLSPEC IntegratorRegistrar : public Registrar {
//    public:
//        virtual ~IntegratorRegistrar() = default;
//
//    };

    /**
     * @author JKM, WBC
     * @brief Constructs new integrators
     * @details Implements the factory and singleton patterns.
     * Constructs a new integrator given the name (e.g. cvode, gillespie)
     * and returns a base pointer to @ref rr::Integrator.
     */
    class RR_DECLSPEC IntegratorFactory {
    public:
        virtual ~IntegratorFactory();

        /**
         * @author JKM, WBC
         * @brief Constructs a new integrator given the name
         * (e.g. cvode, gillespie)
         */
        Integrator *New(const std::string& name, ExecutableModel *m) const;

        /**
         * @author JKM, WBC
         * @brief Registers a new integrator with the factory
         * so that it can be constructed
         * @details Should be called at startup for new integrators.
         */
        void registerIntegrator(Registrar *i);

        /**
         * @author JKM, WBC
         * @brief Returns the singleton instance of the integrator factory
         */
        static IntegratorFactory &getInstance();

        // ** Indexing *********************************************************

        std::size_t getNumIntegrators() const;

        std::string getIntegratorName(std::size_t n) const;

        std::string getIntegratorHint(std::size_t n) const;

        std::string getIntegratorDescription(std::size_t n) const;

    private:
        /**
         * @author JKM, WBC
         * @brief Prevents external instantiation
         */
        IntegratorFactory() {}

        RegistrarVector mRegisteredIntegrators;
    };

}

# endif /* RR_INTEGRATOR_H_ */
