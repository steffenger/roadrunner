/**
 * @file rrc_plugin_api.h
 * @brief roadRunner C API 2012
 * @author Totte Karlsson & Herbert M Sauro
 *
 * <--------------------------------------------------------------
 * This file is part of cRoadRunner.
 * See http://code.google.com/p/roadrunnerlib for more details.
 *
 * Copyright (C) 2012-2013
 *   University of Washington, Seattle, WA, USA
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * In plain english this means:
 *
 * You CAN freely download and use this software, in whole or in part, for personal,
 * company internal, or commercial purposes;
 *
 * You CAN use the software in packages or distributions that you create.
 *
 * You SHOULD include a copy of the license in any redistribution you may make;
 *
 * You are NOT required include the source of software, or of any modifications you may
 * have made to it, in any redistribution you may assemble that includes it.
 *
 * YOU CANNOT:
 *
 * redistribute any piece of this software without proper attribution;
*/

#ifndef rrc_plugin_apiH
#define rrc_plugin_apiH
#include "rrc_exporter.h"
#include "rrc_types.h"
//---------------------------------------------------------------------------

#if defined(__cplusplus)
namespace rrc
{
extern "C"
{
#endif

typedef void (rrcCallConv *pluginCallback)(void*);

/*!
 \brief load plugins

 \return Returns true if Plugins are loaded, false otherwise
 \ingroup pluginRoutines
*/
C_DECL_SPEC bool rrcCallConv loadPlugins(RRHandle handle);

/*!
 \brief unload plugins

 \return Returns true if Plugins are unloaded succesfully, false otherwise
 \ingroup pluginRoutines
*/
C_DECL_SPEC bool rrcCallConv unLoadPlugins(RRHandle handle);

/*!
 \brief Get Number of loaded plugins

 \return Returns the number of loaded plugins, -1 if a problem is encountered
 \ingroup pluginRoutines
*/
C_DECL_SPEC int rrcCallConv getNumberOfPlugins(RRHandle handle);

/*!
 \brief GetPluginNames
 \return Returns names for loaded plugins, NULL otherwise
 \ingroup pluginRoutines
*/
C_DECL_SPEC struct RRStringArray* rrcCallConv getPluginNames(RRHandle handle);

/*!
 \brief GetPluginHandle
 \return Returns a handle to a plugin, with namem name. Returns NULL if plugin is not found
 \ingroup pluginRoutines
*/
C_DECL_SPEC RRPluginHandle rrcCallConv getPlugin(RRHandle handle, const char* pluginName);

/*!
 \brief GetPluginCapabilities
 \return Returns available capabilities for a particular plugin, NULL otherwise
 \ingroup pluginRoutines
*/
C_DECL_SPEC struct RRStringArray* rrcCallConv getPluginCapabilities(RRPluginHandle handle);

/*!
 \brief GetPluginParameters
 \return Returns available parameters for a particular plugin, NULL otherwise
 \ingroup pluginRoutines
*/
C_DECL_SPEC struct RRStringArray* rrcCallConv getPluginParameters(RRPluginHandle handle, const char* capability);

/*!
 \brief GetPluginParameter
 \return Returns a pointer to a parameter for a particular plugin. Returns NULL if absent parameter
 \ingroup pluginRoutines
*/
C_DECL_SPEC RRParameterHandle rrcCallConv getPluginParameter(RRPluginHandle handle, const char* parameterName, const char* capabilitiesName);

/*!
 \brief SetPluginParameter
 \return true if succesful, false otherwise
 \ingroup pluginRoutines
*/
C_DECL_SPEC bool rrcCallConv setPluginParameter(RRPluginHandle handle, const char* parameterName, const char* value);

/*!
 \brief getPluginName
 \param[in] RRPluginHandle handle to plugin
 \return Returns the plugins full name, as a string, NULL otherwise
 \ingroup pluginRoutines
*/
C_DECL_SPEC char* rrcCallConv getPluginName(RRPluginHandle handle);

/*!
 \brief GetPluginInfo
 \param[in] RRPluginHandle handle to plugin
 \return Returns info, as a string, for the plugin, NULL otherwise
 \ingroup pluginRoutines
*/
C_DECL_SPEC char* rrcCallConv getPluginInfo(RRPluginHandle handle);

/*!
 \brief executePlugin (PluginName)
 \param[in] RRPluginHandle handle to plugin
 \return Returns true or false indicating success/failure
 \ingroup pluginRoutines
*/
C_DECL_SPEC bool rrcCallConv executePlugin(RRPluginHandle handle);

/*!
 \brief executePlugin (PluginName)
 \param[in] RRPluginHandle handle to plugin
 \param[in] void*  pointer to user data. Plugin dependent.
 \return Returns true or false indicating success/failure
 \ingroup pluginRoutines
*/
C_DECL_SPEC bool rrcCallConv executePluginEx(RRPluginHandle handle, void* userData);

/*!
 \brief getPluginResult (PluginName)
 \param[in] RRPluginHandle handle to plugin
 \return Returns plugin result if available. NULL otherwise
 \ingroup pluginRoutines
*/
C_DECL_SPEC char* rrcCallConv getPluginResult(RRPluginHandle handle);

/*!
 \brief resetPlugin (PluginName)
 \param[in] RRPluginHandle handle to plugin
 \return Returns true or false indicating success/failure
 \ingroup pluginRoutines
*/
C_DECL_SPEC bool rrcCallConv resetPlugin(RRPluginHandle handle);

/*!
 \brief assignCallbacks
 \param[in] RRPluginHandle handle to plugin
 \param[in] void*  pointer to user data. Plugin dependent.
 \return Returns true or false indicating success/failure
 \ingroup pluginRoutines
*/
C_DECL_SPEC bool rrcCallConv assignCallbacks(RRPluginHandle handle, pluginCallback cb1, pluginCallback cb2, void* userData);


C_DECL_SPEC bool rrcCallConv setInputData(RRPluginHandle handle, void* userData);


#if defined(__cplusplus)
}	//Extern "C"

}	//rrc namespace
#endif


#endif
