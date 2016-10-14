﻿// 
// License notice
//  
// Standards DevKit, version 2.0
// Copyright 2012 ExxonMobil Upstream Research Company
// 
// Third Party Software
// 
// Energistics 
// The following Energistics (c) products were used in the creation of this work: 
// 
// •             WITSML Data Schema Specifications, Version 1.4.1.1 
// •             WITSML API Specifications, version 1.4.1.1 
// •             WITSML Data Schema Specifications, Version 1.3.1.1 
// •             WITSML API Specifications, version 1.3.1 
// •             PRODML Data Schema Specifications, Version 1.2.2 
// •             PRODML Web Service Specifications, Version 2.1.0.1
// •             RESQML Data Schema Specifications, Version 1.1 
// 
// All rights in the WITSML™ Standard, the PRODML™ Standard, and the RESQML™ Standard, or
// any portion thereof, which remain in the Standards DevKit shall remain with Energistics
// or its suppliers and shall remain subject to the terms of the Product License Agreement
// available at http://www.energistics.org/product-license-agreement. 
// 
// Apache
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
// except in compliance with the License. 
// 
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. 
// 
// See the License for the specific language governing permissions and limitations under the
// License.
// 
// HDF5
// HDF5 (Hierarchical Data Format 5) Software Library and Utilities Copyright 2006-2012 by
// The HDF Group. 
// 
// NCSA HDF5 (Hierarchical Data Format 5) Software Library and Utilities Copyright 1998-2006
// by the Board of Trustees of the University of Illinois. 
// 
// All rights reserved. 
// 
// Redistribution and use in source and binary forms, with or without modification, are
// permitted for any purpose (including commercial purposes) provided that the following
// conditions are met: 
//    1. Redistributions of source code must retain the above copyright notice, this list
//       of conditions, and the following disclaimer. 
//    2. Redistributions in binary form must reproduce the above copyright notice, this
//       list of conditions, and the following disclaimer in the documentation and/or
// 	  materials provided with the distribution. 
//    3. In addition, redistributions of modified forms of the source or binary code must
//       carry prominent notices stating that the original code was changed and the date of
// 	  the change. 
//    4. All publications or advertising materials mentioning features or use of this
//       software are asked, but not required, to acknowledge that it was developed by The
// 	  HDF Group and by the National Center for Supercomputing Applications at the 
// 	  University of Illinois at Urbana-Champaign and credit the contributors. 
//    5. Neither the name of The HDF Group, the name of the University, nor the name of any
//       Contributor may be used to endorse or promote products derived from this software
// 	  without specific prior written permission from The HDF Group, the University, or
// 	  the Contributor, respectively. 
// 
// DISCLAIMER: THIS SOFTWARE IS PROVIDED BY THE HDF GROUP AND THE CONTRIBUTORS "AS IS" WITH
// NO WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED. In no event shall The HDF Group or
// the Contributors be liable for any damages suffered by the users arising out of the use
// of this software, even if advised of the possibility of such damage. 
// 
// Contributors: National Center for Supercomputing Applications (NCSA) at the University of
// Illinois, Fortner Software, Unidata Program Center (netCDF), The Independent JPEG Group
// (JPEG), Jean-loup Gailly and Mark Adler (gzip), and Digital Equipment Corporation (DEC). 
// 
// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 11.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Generator
{
    using System;

    /// <summary>
    /// Class to produce the template output
    /// </summary>

#line 1 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class ResqmlHD5Template : ResqmlHD5TemplateBase
    {
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText(String Version)
        {

#line 2 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SchemaSetClassCreator.GetLicenseText()));

#line default
#line hidden
            this.Write("\r\n");
            this.Write("\r\nusing System;\r\n\r\nnamespace Energistics.DataAccess." + Version + ".ComponentSchemas\r\n{" +
                    "\r\n");

#line 10 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"

            string[,] classes = new string[,] { 
                                    { "ResqmlSplitNodeSet : Object", "Point3D", "[]", "IjkGridHdfGroup", "null" },
									{ "ResqmlTriangulatedPatch : Object", "Point3D", "[]", "TriangulatedHdfGroup", "point3dSet" },
									{ "ResqmlTriangulatedPatch : Object", "Triangle", "[]", "TriangulatedHdfGroup", "triangleNodeIndexSet" }, 
									{ "ResqmlTriangulatedPatch : Object", "Edge", "[]", "TriangulatedHdfGroup", "splitEdgeNodeIndexSet" },
									{ "ResqmlPointSetPatch : Object", "Point3D", "[]", "PointSetHdfGroup", "null" }, 
									{ "ResqmlAbstractIJKGrid : Object", "Point3D", "[,]", "IjkGridHdfGroup", "explicitNodeList" }, 
									{ "ResqmlAbstractIJKGrid : Object", "SplitLineReference", "[]", "IjkGridHdfGroup", "splitLineReferences" }, 
									{ "ResqmlAbstractIJKGrid : Object", "byte", "[,,]", "IjkGridHdfGroup", "topologyFlags" }, 
									{ "ResqmlAbstractIJKGrid : Object", "SplitNodeReference", "[]", "IjkGridHdfGroup", "splitNodeReferences" }, 
									{ "ResqmlAbstractIJKGrid : Object", "Point3D", "[]", "IjkGridHdfGroup", "splitNodes" },
									{ "ResqmlPillarSetPatch : Object", "Point3D", "[,]", "PillarSetHdfGroup", "pillarSet" },
									{ "ResqmlIJKNonStandardAdjacency : Object", "GridIJKCellFacePair", "[]", "HdfRepresentation", "null" },
									{ "ResqmlGrid2dPatch : Object", "double", "[,]", "Grid2dHdfGroup", "zValueSet" },
									{ "ResqmlExplicitNodeSet : Object", "int", "[,,]", "IjkGridHdfGroup", "null" }
                                  };
            for (int i = 0; i < classes.GetLength(0); i++)
            {
                string name = classes[i, 0];
                string type = classes[i, 1];
                string array = classes[i, 2];
                string property = classes[i, 3];
                string oriddatasetname = classes[i, 4];
                string quotdatasetname = (oriddatasetname == "null") ? oriddatasetname : String.Format("\"{0}\"", oriddatasetname);
                string readname = (oriddatasetname == "null") ? property : oriddatasetname;
                readname = readname.Substring(0, 1).ToUpper() + readname.Substring(1);



#line default
#line hidden
                this.Write("    public partial class ");

#line 38 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(name));

#line default
#line hidden
                this.Write("\r\n    {\r\n        /// <summary>\r\n        /// Reads HDF5 data\r\n        /// </summar" +
                        "y>\r\n        /// <param name=\"doc\">Parent ResqmlDocument</param>\r\n        /// <re" +
                        "turns>The data returned from the HDF5 document</returns>\r\n        public ");

#line 45 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(type));

#line default
#line hidden

#line 45 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(array));

#line default
#line hidden
                this.Write(" Read");

#line 45 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(readname));

#line default
#line hidden
                this.Write("(ResqmlDocument doc)\r\n        {\r\n            return this.Read");

#line 47 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(readname));

#line default
#line hidden
                this.Write(@"(doc, null, null);
        }

        /// <summary>
        /// Reads HDF5 data using hyperslabbing
        /// </summary>
        /// <param name=""doc"">Parent ResqmlDocument</param>
		/// <param name=""start"">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name=""count"">Number of blocks to include in selection, null if not hyperslabbing</param>
        /// <returns>The data returned from the HDF5 document</returns>
        public ");

#line 57 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(type));

#line default
#line hidden

#line 57 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(array));

#line default
#line hidden
                this.Write(" Read");

#line 57 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(readname));

#line default
#line hidden
                this.Write("(ResqmlDocument doc, long[] start, long[] count)\r\n        {\r\n            return (" +
                        "");

#line 59 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(type));

#line default
#line hidden

#line 59 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(array));

#line default
#line hidden
                this.Write(")this.");

#line 59 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(property));

#line default
#line hidden
                this.Write(".Read<");

#line 59 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(type));

#line default
#line hidden
                this.Write(">(doc, start, count, ");

#line 59 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(quotdatasetname));

#line default
#line hidden
                this.Write(");\r\n        }\r\n\r\n\t\t/// <summary>\r\n        /// Writes HDF5 data\r\n        /// </sum" +
                        "mary>\r\n        /// <param name=\"doc\">Parent ResqmlDocument</param>\r\n        /// " +
                        "<param name=\"obj\">Object to write</param>        \r\n\t\tpublic void Write");

#line 67 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(readname));

#line default
#line hidden
                this.Write("(ResqmlDocument doc, ");

#line 67 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(type));

#line default
#line hidden

#line 67 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(array));

#line default
#line hidden
                this.Write(" obj)\r\n        {\r\n            this.Write");

#line 69 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(readname));

#line default
#line hidden
                this.Write(@"(doc, obj, null, null);
        }

		/// <summary>
        /// Writes HDF5 data using hyperslabbing
        /// </summary>
        /// <param name=""doc"">Parent ResqmlDocument</param>
        /// <param name=""obj"">Object to write</param>
        /// <param name=""start"">Offset of start of subsetting selection, null if not hyperslabbing</param>
        /// <param name=""filespace"">Total size to allot for the data within the HDF5 file</param>
		public void Write");

#line 79 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(readname));

#line default
#line hidden
                this.Write("(ResqmlDocument doc, ");

#line 79 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(type));

#line default
#line hidden

#line 79 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(array));

#line default
#line hidden
                this.Write(" obj, long[] start, long[] filespace)\r\n        {\r\n\t\t    if (this.");

#line 81 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(property));

#line default
#line hidden
                this.Write(" == null) \r\n\t\t\t{\r\n\t\t\t    this.");

#line 83 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(property));

#line default
#line hidden
                this.Write(" = new ResqmlHdfGroup();\r\n\t\t\t}\r\n            this.");

#line 85 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(property));

#line default
#line hidden
                this.Write(".Write<");

#line 85 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(type));

#line default
#line hidden
                this.Write(">(doc, obj, start, filespace, ");

#line 85 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(quotdatasetname));

#line default
#line hidden
                this.Write(@");
        }

		/// <summary>
        /// Checks to see if dataset exists
        /// </summary>
        /// <param name=""doc"">Parent ResqmlDocument</param>
        /// <returns>True if the dataset exists, false if it does not</returns>
        public bool DoesExist");

#line 93 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(readname));

#line default
#line hidden
                this.Write("(ResqmlDocument doc)\r\n        {\r\n            if (this.");

#line 95 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(property));

#line default
#line hidden
                this.Write(" == null) return false;\r\n            HDF5DotNet.H5DataSetId dataId = this.");

#line 96 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(property));

#line default
#line hidden
                this.Write(".GetDataSetId(doc, ");

#line 96 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"
                this.Write(this.ToStringHelper.ToStringWithCulture(quotdatasetname));

#line default
#line hidden
                this.Write(", HDF5DotNet.H5F.OpenMode.ACC_RDONLY, true);\r\n\r\n\t\t\tif (dataId == null) \r\n\t\t\t{\r\n\t\t" +
                        "\t    return false;\r\n\t\t\t}\r\n\t\t\telse\r\n\t\t\t{\r\n\t\t\t\tHDF5DotNet.H5D.close(dataId);\r\n\t\t\t " +
                        "   return true;\r\n\t\t\t}\r\n        }\r\n    }\r\n");

#line 109 "C:\TFS\ADI_COMMON\StdDevkit\Dev\RESQML\DevKitGenerator\Generator\ResqmlHD5Template.tt"

            }


#line default
#line hidden
            this.Write("}");
            return this.GenerationEnvironment.ToString();
        }
        private global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost hostValue;
        /// <summary>
        /// The current host for the text templating engine
        /// </summary>
        public virtual global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost Host
        {
            get
            {
                return this.hostValue;
            }
            set
            {
                this.hostValue = value;
            }
        }
    }

#line default
#line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public class ResqmlHD5TemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0)
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
