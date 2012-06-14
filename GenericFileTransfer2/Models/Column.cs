using System;
using System.Runtime.Serialization;
using Catel.Data;

namespace GenericFileTransfer2.Models
{
    /// <summary>
    /// name Data object class which fully supports serialization, property changed notifications,
    /// backwards compatibility and error checking.
    /// </summary>
#if !SILVERLIGHT
    [Serializable]
#endif
    public class Column : DataObjectBase<Column>
    {
        #region Variables
        #endregion

        #region Constructor & destructor
        /// <summary>
        /// Initializes a new object from scratch.
        /// </summary>
        public Column() { }

#if !SILVERLIGHT
        /// <summary>
        /// Initializes a new object based on <see cref="SerializationInfo"/>.
        /// </summary>
        /// <param name="info"><see cref="SerializationInfo"/> that contains the information.</param>
        /// <param name="context"><see cref="StreamingContext"/>.</param>
        protected Column(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
#endif
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the property value.
        /// </summary>
        public int ReportId
        {
            get { return GetValue<int>(ReportIdProperty); }
            set { SetValue(ReportIdProperty, value); }
        }

        /// <summary>
        /// Register the ReportId property so it is known in the class.
        /// </summary>
        public static readonly PropertyData ReportIdProperty = RegisterProperty("ReportId", typeof(int), null);

        /// <summary>
        /// Gets or sets the property value.
        /// </summary>
        public string Header
        {
            get { return GetValue<string>(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        /// <summary>
        /// Register the Header property so it is known in the class.
        /// </summary>
        public static readonly PropertyData HeaderProperty = RegisterProperty("Header", typeof(string), null);

        /// <summary>
        /// Gets or sets the property value.
        /// </summary>
        public int ColumnPosition
        {
            get { return GetValue<int>(ColumnPositionProperty); }
            set { SetValue(ColumnPositionProperty, value); }
        }

        /// <summary>
        /// Register the ColumnPosition property so it is known in the class.
        /// </summary>
        public static readonly PropertyData ColumnPositionProperty = RegisterProperty("ColumnPosition", typeof(int), null);

        #endregion

        #region Methods
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
        #endregion
    }
}
