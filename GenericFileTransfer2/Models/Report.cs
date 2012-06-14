using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Catel.Data;
using System.Runtime.Serialization;

namespace GenericFileTransfer2.Models
{
    /// <summary>
    /// name Data object class which fully supports serialization, property changed notifications,
    /// backwards compatibility and error checking.
    /// </summary>
#if !SILVERLIGHT
    [Serializable]
#endif
    public class Report : DataObjectBase<Report>
    {
        #region Variables
        #endregion

        #region Constructor & destructor
        /// <summary>
        /// Initializes a new object from scratch.
        /// </summary>
        public Report() { }

#if !SILVERLIGHT
        /// <summary>
        /// Initializes a new object based on <see cref="SerializationInfo"/>.
        /// </summary>
        /// <param name="info"><see cref="SerializationInfo"/> that contains the information.</param>
        /// <param name="context"><see cref="StreamingContext"/>.</param>
        protected Report(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
#endif
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the property value.
        /// </summary>
        public string ReportName
        {
            get { return GetValue<string>(ReportName); }
            set { SetValue(ReportNameProperty, value); }
        }

        /// <summary>
        /// Register the ReportName property so it is known in the class.
        /// </summary>
        public static readonly PropertyData ReportNameProperty = RegisterProperty("ReportName", typeof(string), null);
        

        /// <summary>
        /// Gets or sets the property value.
        /// </summary>
        public bool Header
        {
            get { return GetValue<bool>(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        /// <summary>
        /// Register the Header property so it is known in the class.
        /// </summary>
        public static readonly PropertyData HeaderProperty = RegisterProperty("Header", typeof(bool), null);

        /// <summary>
        /// Gets or sets the property value.
        /// </summary>
        public int HeaderRow
        {
            get { return GetValue<int>(HeaderRowProperty); }
            set { SetValue(HeaderRowProperty, value); }
        }

        /// <summary>
        /// Register the HeaderRow property so it is known in the class.
        /// </summary>
        public static readonly PropertyData HeaderRowProperty = RegisterProperty("HeaderRow", typeof(int), null);


        /// <summary>
        /// Gets or sets the property value.
        /// </summary>
        public int ResultRow
        {
            get { return GetValue<int>(ResultRowProperty); }
            set { SetValue(ResultRowProperty, value); }
        }

        /// <summary>
        /// Register the ResultRow property so it is known in the class.
        /// </summary>
        public static readonly PropertyData ResultRowProperty = RegisterProperty("ResultRow", typeof(int), null);

        /// <summary>
        /// Gets or sets the property value.
        /// </summary>
        public string Separator
        {
            get { return GetValue<string>(SeparatorProperty); }
            set { SetValue(SeparatorProperty, value); }
        }

        /// <summary>
        /// Register the Separator property so it is known in the class.
        /// </summary>
        public static readonly PropertyData SeparatorProperty = RegisterProperty("Separator", typeof(string), null);

        /// <summary>
        /// Gets or sets the property value.
        /// </summary>
        public string FilePath
        {
            get { return GetValue<string>(FilePathProperty); }
            set { SetValue(FilePathProperty, value); }
        }

        /// <summary>
        /// Register the FilePath property so it is known in the class.
        /// </summary>
        public static readonly PropertyData FilePathProperty = RegisterProperty("FilePath", typeof(string), null);

        /// <summary>
        /// Gets or sets the property value.
        /// </summary>
        public string SheetName
        {
            get { return GetValue<string>(SheetNameProperty); }
            set { SetValue(SheetNameProperty, value); }
        }

        /// <summary>
        /// Register the SheetName property so it is known in the class.
        /// </summary>
        public static readonly PropertyData SheetNameProperty = RegisterProperty("SheetName", typeof(string), null);

        #endregion

        //#region Methods
        ///// <summary>
        ///// Validates the fields.
        ///// </summary>
        //protected override void ValidateFields()
        //{
        //    // TODO: Implement any field validation of this object. Simply set any error by using the SetFieldError method
        //}

        ///// <summary>
        ///// Validates the business rules.
        ///// </summary>
        //protected override void ValidateBusinessRules()
        //{
        //    // TODO: Implement any business rules of this object. Simply set any error by using the SetBusinessRuleError method
        //}
        //#endregion
    }
}
