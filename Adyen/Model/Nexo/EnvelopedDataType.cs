﻿namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EnvelopedDataType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KEK", typeof(KEKType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("KeyTransport", typeof(KeyTransportType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object[] Items;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EncryptedContentType EncryptedContent;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("v0")]
        public string Version;

        public EnvelopedDataType()
        {
            this.Version = "v0";
        }
    }
}