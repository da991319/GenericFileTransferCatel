using Catel.MVVM;
using GenericFileTransfer2.Models;
using Catel.Data;
using System.Collections.ObjectModel;

namespace GenericFileTransfer2.ViewModels
{
    /// <summary>
    /// name view model.
    /// </summary>
    public class ReportViewModel : ViewModelBase
    {
        #region Variables
        private Mode _mode;
        #endregion

        #region Constructor & destructor
        /// <summary>
        /// Initializes a new instance of the <see cref="nameViewModel"/> class.
        /// </summary>
        public ReportViewModel()
        {
        }

        public ReportViewModel(Mode mode)
        {
            _mode = mode;

            if (_mode.Equals(ViewModels.Mode.Add))
            {
                
            }
            else
            {

            }
        }
        #endregion

        #region Properties

        // TODO: Register models with the vmpropmodel codesnippet
        /// <summary>
        /// Gets or Sets the current report.
        /// </summary>
        [Model]
        public Report CurrentReport 
        {
            get { return GetValue<Report>(currentReportProperty); }
            private set { SetValue(currentReportProperty, value); }
        }

        /// <summary>
        /// Register the name property so it is known in the class.
        /// </summary>
        public static readonly PropertyData currentReportProperty = RegisterProperty("CurrentReport", typeof(Report));
        // TODO: Register view model properties with the vmprop or vmpropviewmodeltomodel codesnippets

        /// <summary>
        /// Gets or set the List of Report.
        /// </summary>
        public ObservableCollection<Report> Reports
        {
            get { return GetValue<ObservableCollection<Report>>(ReportsProperty); }
            set { SetValue(ReportsProperty, value); }
        }

        /// <summary>
        /// Register the Reports property so it is known in the class.
        /// </summary>
        public static readonly PropertyData ReportsProperty = RegisterProperty("Reports", typeof(ObservableCollection<Report>), null);


        #endregion

        #region Commands
        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets
        #endregion

        #region Methods
        #endregion
    }
}
