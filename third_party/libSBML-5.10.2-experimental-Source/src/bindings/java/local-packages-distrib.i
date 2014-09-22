/**
 * @file:   local-packages-distrib.i
 * @brief:  Implementation of the distrib class
 * @author: Generated by autocreate code
 *
 * <!--------------------------------------------------------------------------
 * This file is part of libSBML.  Please visit http://sbml.org for more
 * information about SBML, and the latest version of libSBML.
 *
 * Copyright (C) 2009-2013 jointly by the following organizations:
 *     1. California Institute of Technology, Pasadena, CA, USA
 *     2. EMBL European Bioinformatics Institute (EMBL-EBI), Hinxton, UK
 *
 * Copyright (C) 2006-2008 by the California Institute of Technology,
 *     Pasadena, CA, USA 
 *
 * Copyright (C) 2002-2005 jointly by the following organizations:
 *     1. California Institute of Technology, Pasadena, CA, USA
 *     2. Japan Science and Technology Agency, Japan
 *
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation.  A copy of the license agreement is provided
 * in the file named "LICENSE.txt" included with this software distribution
 * and also available online as http://sbml.org/software/libsbml/license.html
 * ------------------------------------------------------------------------ -->
 */
#ifdef USE_DISTRIB
/**
 * Adds DownCastBase(long cPtr, boolean owner) method for the distrib package extension
 */
%typemap(javacode) DistribExtension
%{
	public SBasePlugin DowncastSBasePlugin(long cPtr, boolean owner)
	{
		if (cPtr == 0) return null;

		SBasePlugin sbp = new SBasePlugin(cPtr, false);
		SBase sb = sbp.getParentSBMLObject();

		switch( sb.getTypeCode() )
		{
			case (int) libsbml.SBML_FUNCTION_DEFINITION:
				return new DistribFunctionDefinitionPlugin(cPtr, owner);

			default:
				return new SBasePlugin(cPtr, owner);
		}
	}

	public SBase DowncastSBase(long cPtr, boolean owner)
	{
		if (cPtr == 0) return null;

		SBase sb = new SBase(cPtr, false);
		switch( sb.getTypeCode() )
		{
			case (int) libsbml.SBML_LIST_OF:
				String name = sb.getElementName();
				if (name.equals("listOfDistribInputs"))
				{
					return new ListOfDistribInputs(cPtr, owner);
				}

				return new ListOf(cPtr, owner);

			case (int) libsbml.SBML_DISTRIB_DRAW_FROM_DISTRIBUTION:
				return new DrawFromDistribution(cPtr, owner);

			case (int) libsbml.SBML_DISTRIB_INPUT:
				return new DistribInput(cPtr, owner);

			case (int) libsbml.SBML_DISTRIB_UNCERTAINTY:
				return new Uncertainty(cPtr, owner);

			default:
				return new SBase(cPtr, owner);
		}
	}

%}

COVARIANT_RTYPE_CLONE(DistribExtension)
COVARIANT_RTYPE_CLONE(DrawFromDistribution)
COVARIANT_RTYPE_CLONE(DistribInput)
COVARIANT_RTYPE_CLONE(Uncertainty)
COVARIANT_RTYPE_CLONE(UncertMLNode)
COVARIANT_RTYPE_CLONE(ListOfDistribInputs)

COVARIANT_RTYPE_LISTOF_GET_REMOVE(DistribInput)

SBMLCONSTRUCTOR_EXCEPTION(DistribPkgNamespaces)
SBMLCONSTRUCTOR_EXCEPTION(DrawFromDistribution)
SBMLCONSTRUCTOR_EXCEPTION(DistribInput)
SBMLCONSTRUCTOR_EXCEPTION(Uncertainty)
SBMLCONSTRUCTOR_EXCEPTION(UncertMLNode)
SBMLCONSTRUCTOR_EXCEPTION(ListOfDistribInputs)

#endif /* USE_DISTRIB */

