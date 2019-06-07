﻿namespace Adyen.Model.Nexo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Instalment
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Instalment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Instalment1;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int SequenceNumber;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlanID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int Period;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PeriodUnitType PeriodUnit;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FirstPaymentDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public int TotalNbOfPayments;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal CumulativeAmount;

     
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal FirstAmount;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Charges;
    }
}