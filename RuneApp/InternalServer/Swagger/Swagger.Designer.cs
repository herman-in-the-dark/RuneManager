﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RuneApp.InternalServer.Swagger {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Swagger {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Swagger() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RuneApp.InternalServer.Swagger.Swagger", typeof(Swagger).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // swagger-client.js
        ///// version 2.1.0-alpha.5
        ////**
        /// * Array Model
        /// **/
        ///var ArrayModel = function (definition) {
        ///	this.name = &quot;name&quot;;
        ///	this.definition = definition || {};
        ///	this.properties = [];
        ///	this.type;
        ///	this.ref;
        ///
        ///	var requiredFields = definition.enum || [];
        ///	var items = definition.items;
        ///	if (items) {
        ///		var type = items.type;
        ///		if (items.type) {
        ///			this.type = typeFromJsonSchema(type.type, type.format);
        ///		}
        ///		else {
        ///			this.ref = items[&apos;$ref&apos;];
        ///		}
        ///	}
        ///}
        ///
        ///ArrayModel.prototype.crea [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string swagger_client {
            get {
                return ResourceManager.GetString("swagger_client", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /* Original style from softwaremaniacs.org (c) Ivan Sagalaev &lt;Maniac@SoftwareManiacs.Org&gt; */
        ///.swagger-section pre code {
        ///  display: block;
        ///  padding: 0.5em;
        ///  background: #F0F0F0;
        ///}
        ///.swagger-section pre code,
        ///.swagger-section pre .subst,
        ///.swagger-section pre .tag .title,
        ///.swagger-section pre .lisp .title,
        ///.swagger-section pre .clojure .built_in,
        ///.swagger-section pre .nginx .title {
        ///  color: black;
        ///}
        ///.swagger-section pre .string,
        ///.swagger-section pre .title,
        ///.swagger-section pre .constant,
        ///. [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string swagger_css {
            get {
                return ResourceManager.GetString("swagger_css", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // swagger.js
        ///// version 2.0.48
        ///
        ///(function () {
        ///  var __bind = function (fn, me) {
        ///    return function () {
        ///      return fn.apply(me, arguments);
        ///    };
        ///  };
        ///
        ///  var log = function () {
        ///    log.history = log.history || [];
        ///    log.history.push(arguments);
        ///    if (this.console) {
        ///      console.log(Array.prototype.slice.call(arguments)[0]);
        ///    }
        ///  };
        ///
        ///  /**
        ///   * allows override of the default value based on the parameter being
        ///   * supplied
        ///   **/
        ///  var applyParameterMacro = function (mo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string swagger_js {
            get {
                return ResourceManager.GetString("swagger_js", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // swagger-ui.js
        ///// version 2.1.0-alpha.7
        ///$(function () {
        ///
        ///	// Helper function for vertically aligning DOM elements
        ///	// http://www.seodenver.com/simple-vertical-align-plugin-for-jquery/
        ///	$.fn.vAlign = function () {
        ///		return this.each(function (i) {
        ///			var ah = $(this).height();
        ///			var ph = $(this).parent().height();
        ///			var mh = (ph - ah) / 2;
        ///			$(this).css(&apos;margin-top&apos;, mh);
        ///		});
        ///	};
        ///
        ///	$.fn.stretchFormtasticInputWidthToParent = function () {
        ///		return this.each(function (i) {
        ///			var p_widt [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string swagger_ui {
            get {
                return ResourceManager.GetString("swagger_ui", resourceCulture);
            }
        }
    }
}
