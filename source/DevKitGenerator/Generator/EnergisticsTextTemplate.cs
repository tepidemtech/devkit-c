﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Generator
{
    using System.IO;
    using System.Linq;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Linq;
    using System.Reflection;
    using System.Xml.Serialization;
    using Energistics.Generator;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class EnergisticsTextTemplate : EnergisticsTextTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 3 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SchemaSetClassCreator.GetLicenseText()));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 18 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

    SchemaSetClassCreator generator = new SchemaSetClassCreator(mlPath, mlVersion, enumClassNames, versionString);

            
            #line default
            #line hidden
            this.Write(@"//This code was generated using the Energistics Generator tool.  Direct changes to this code will be lost
//during regeneration.

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

using Energistics.DataAccess.");
            
            #line 32 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mlVersion));
            
            #line default
            #line hidden
            this.Write(".ComponentSchemas;\r\nusing Energistics.DataAccess.");
            
            #line 33 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mlVersion));
            
            #line default
            #line hidden
            this.Write(".ReferenceData;\r\nusing Energistics.DataAccess.Reflection;\r\nusing Energistics.Data" +
                    "Access.Validation;\r\n\r\nnamespace Energistics.DataAccess.");
            
            #line 37 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(mlVersion));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    #region Classes\r\n");
            
            #line 40 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

    foreach (Type type in generator.Classes)
    {
        if(!type.Name.StartsWith("obj_") && !type.Name.Equals("abstractObject"))
        {

            
            #line default
            #line hidden
            this.Write("    namespace ComponentSchemas \r\n    {\r\n");
            
            #line 48 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("    /// <summary>\r\n    /// ");
            
            #line 52 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetDescription(type)));
            
            #line default
            #line hidden
            this.Write("\r\n    /// </summary>\r\n");
            
            #line 54 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

        foreach (XmlIncludeAttribute include in type.GetCustomAttributes(typeof(XmlIncludeAttribute), false))
        {

            
            #line default
            #line hidden
            this.Write("    [System.Xml.Serialization.XmlIncludeAttribute(typeof(");
            
            #line 58 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.RenameClass(include.Type)));
            
            #line default
            #line hidden
            this.Write("))]\r\n");
            
            #line 59 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("    [System.CodeDom.Compiler.GeneratedCodeAttribute(\"");
            
            #line 62 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Assembly.GetExecutingAssembly().GetName().Name));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 62 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Assembly.GetExecutingAssembly().GetName().Version));
            
            #line default
            #line hidden
            this.Write("\")]\r\n    [System.SerializableAttribute()]\r\n    [System.Diagnostics.DebuggerStepTh" +
                    "roughAttribute()]\r\n    [System.ComponentModel.DesignerCategoryAttribute(\"code\")]" +
                    "\r\n");
            
            #line 66 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

    if(generator.GetXmlRootName(type) != null)
    {

            
            #line default
            #line hidden
            this.Write("    [System.Xml.Serialization.XmlTypeAttribute(Namespace=\"");
            
            #line 70 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetXmlNamespace(type)));
            
            #line default
            #line hidden
            this.Write("\")]\r\n    [System.Xml.Serialization.XmlRootAttribute(\"");
            
            #line 71 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetXmlRootName(type)));
            
            #line default
            #line hidden
            this.Write("\", Namespace=\"");
            
            #line 71 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetXmlNamespace(type)));
            
            #line default
            #line hidden
            this.Write("\", IsNullable=false)]\r\n");
            
            #line 72 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

    }
    else
    {

            
            #line default
            #line hidden
            this.Write("    [System.Xml.Serialization.XmlTypeAttribute(TypeName=\"");
            
            #line 77 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Name));
            
            #line default
            #line hidden
            this.Write("\", Namespace=\"");
            
            #line 77 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetXmlNamespace(type)));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 78 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("\t");
            
            #line 81 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetEnergisticsDataObjectAttribute(type)));
            
            #line default
            #line hidden
            this.Write("[Description(\"");
            
            #line 81 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetDescription(type).Replace("\"", "")));
            
            #line default
            #line hidden
            this.Write("\")]\r\n    public");
            
            #line 82 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.IsAbstract ? " abstract" : string.Empty));
            
            #line default
            #line hidden
            this.Write(" partial class ");
            
            #line 82 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.RenameClass(type)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 82 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.BaseType.Equals(typeof(object)) ?  ": Object" : string.Format(": {0}", generator.RenameClass(type.BaseType))));
            
            #line default
            #line hidden
            
            #line 82 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.RenameClass(type).EndsWith("List") ? ", IEnergisticsCollection" : generator.GetDataObjectInterface(type)));
            
            #line default
            #line hidden
            this.Write(", INotifyPropertyChanged\r\n    {\r\n");
            
            #line 84 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetConstructor(type)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 85 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
        
        foreach (var property in type.GetProperties())
        {
            if(property.DeclaringType.Equals(type))
            {
                if(property.GetCustomAttributes(typeof(XmlIgnoreAttribute), false).Length > 0)
                {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 93 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetDescription(type, property.Name)));
            
            #line default
            #line hidden
            this.Write("\r\n        [XmlIgnore]\r\n        [Browsable(false)]\r\n");
            
            #line 96 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

                }
                else
                if(property.GetCustomAttributes(typeof(XmlTextAttribute), false).Length > 0)
                {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 102 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetDescription(type, property.Name)));
            
            #line default
            #line hidden
            this.Write("\r\n        ");
            
            #line 103 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetValidationAttributes(type, property)));
            
            #line default
            #line hidden
            this.Write("\r\n        [XmlText]\r\n");
            
            #line 105 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

                }
				else if (property.GetCustomAttributes(typeof(XmlElementAttribute), false).Length > 1)
				{

            
            #line default
            #line hidden
            
            #line 110 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.ExpandChoiceAttributes(type, property)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 111 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
				    
					continue;
				}
                else
                {				    
				    
                    object[] elementAttribute = property.GetCustomAttributes(typeof(XmlElementAttribute), false);
                    if(elementAttribute.Length > 0)
                    {
					   XmlElementAttribute xmlElemAttr = (elementAttribute[0] as XmlElementAttribute);

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 122 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetDescription(type, property.Name)));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 123 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetValidationAttributes(type, property)));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 124 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetXmlElementAttrTag(xmlElemAttr, property)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 125 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

                    }
                    else
                    {
                        object[] attributetAttributes = property.GetCustomAttributes(typeof(XmlAttributeAttribute), false);
                        if(attributetAttributes.Length > 0)
                        {
                            XmlAttributeAttribute attribute = attributetAttributes[0] as XmlAttributeAttribute;

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 134 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetDescription(type, property.Name)));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 135 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetValidationAttributes(type, property)));
            
            #line default
            #line hidden
            this.Write("\r\n        [XmlAttribute(\"");
            
            #line 136 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.IsNullOrEmpty(attribute.AttributeName) ? property.Name : attribute.AttributeName));
            
            #line default
            #line hidden
            this.Write("\"");
            
            #line 136 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attribute.Form.HasFlag(XmlSchemaForm.Qualified) ? ", Form = System.Xml.Schema.XmlSchemaForm.Qualified" : String.Empty));
            
            #line default
            #line hidden
            
            #line 136 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.IsNullOrEmpty(attribute.Namespace) ? String.Empty : String.Format(", Namespace = \"{0}\"", attribute.Namespace)));
            
            #line default
            #line hidden
            this.Write(")]\r\n\t\t");
            
            #line 137 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetSurrogate(type, property)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 138 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
                      
                        }
                        else
                        {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 143 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetDescription(type, property.Name)));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 144 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetValidationAttributes(type, property)));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 145 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetXmlElementOrXmlArray(type, property)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 146 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
						}
                    }
                }

		        

            
            #line default
            #line hidden
            this.Write("        public ");
            
            #line 152 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.RenameClass(property.PropertyType)));
            
            #line default
            #line hidden
            
            #line 152 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.MakePropertyNullable(property)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 152 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.RenameProperty(property)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 152 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetGetterSetter(null, type, property)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 153 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

                if (generator.IsItemsList(type, property)) {

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 156 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetDescription(type, property.Name)));
            
            #line default
            #line hidden
            this.Write("\r\n        [XmlIgnore]\t\t\r\n        public IList Items\r\n        {\r\n\t\t    get\r\n\t\t\t{\r\n" +
                    "\t\t\t    return ");
            
            #line 162 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.RenameProperty(property)));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t\t}\r\n        }\r\n");
            
            #line 165 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

				}
            }
        }

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 171 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

      if (type.BaseType == typeof(Object)) { 

            
            #line default
            #line hidden
            this.Write(@"        
		#region INotifyPropertyChanged Members
		/// <summary>
        /// Occurs when a property value changes. 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
        /// Triggers PropertyChanged Event
        /// </summary>
        /// <param name=""info"">Name of property changed</param>
        protected void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion INotifyPropertyChanged Members
");
            
            #line 192 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

  } 

            
            #line default
            #line hidden
            this.Write("    } //here\r\n");
            
            #line 196 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

        if(!type.Name.StartsWith("obj_") && !type.Name.Equals("abstractObject"))
        {

            
            #line default
            #line hidden
            this.Write("    }\r\n");
            
            #line 201 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 205 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("    #endregion\r\n\r\n    #region Enumerations\r\n    namespace ReferenceData {\r\n");
            
            #line 212 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

    foreach (Type type in generator.Enums)
    {
	    if (!enumClassNames.Contains(type.Name)) 
		{

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// ");
            
            #line 219 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetDescription(type)));
            
            #line default
            #line hidden
            this.Write("\r\n        /// </summary>\r\n        [System.CodeDom.Compiler.GeneratedCodeAttribute" +
                    "(\"xsd\", \"4.0.30319.1\")]\r\n        [System.SerializableAttribute()]\r\n        [Syst" +
                    "em.Xml.Serialization.XmlTypeAttribute(Namespace=\"");
            
            #line 223 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetXmlNamespace(type)));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        [Description(\"");
            
            #line 224 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetDescription(type).Replace("\"", "")));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        public enum ");
            
            #line 225 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.RenameClass(type)));
            
            #line default
            #line hidden
            this.Write(" \r\n        {\r\n");
            
            #line 227 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

        FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.GetField | BindingFlags.Public);

        for(int i = 0; i < fields.Length; i++)
        {
            FieldInfo field = fields[i];
            object[] enumAttributes = field.GetCustomAttributes(typeof(XmlEnumAttribute), false);

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 234 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetDescription(type, field.Name)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 235 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

            if(enumAttributes.Length > 0)
            {
                XmlEnumAttribute attribute = enumAttributes[0] as XmlEnumAttribute;

            
            #line default
            #line hidden
            this.Write("          [XmlEnum(\"");
            
            #line 239 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.IsNullOrEmpty(field.Name) ? field.Name : attribute.Name));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 240 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

            }

            
            #line default
            #line hidden
            this.Write("          ");
            
            #line 242 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(generator.GetEnumName(field.Name)));
            
            #line default
            #line hidden
            
            #line 242 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(i == fields.Length - 1 ? string.Empty : ","));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 243 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 247 "C:\projects\source\DevKitGenerator\Generator\EnergisticsTextTemplate.tt"

        } // end if
    } // end for

            
            #line default
            #line hidden
            this.Write("    }\r\n    #endregion\r\n}");
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
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class EnergisticsTextTemplateBase
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
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
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
