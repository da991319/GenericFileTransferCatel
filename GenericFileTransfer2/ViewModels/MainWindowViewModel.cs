namespace GenericFileTransfer2.ViewModels
{
    using Catel.MVVM;
    using Catel.Data;

    /// <summary>
    /// MainWindow view model.
    /// </summary>
    public class MainWindowViewModel : ViewModelBase
    {
        #region Variables
        #endregion

        #region Constructor & destructor
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel()
            : base()
        {
            HomeViewCommand = new Command(OnHomeViewCommandExecute, OnHomeViewCommandCanExecute);
            AddReport = new Command(OnAddReportExecute, OnAddReportCanExecute);
            CurrentViewModel = new HomeViewModel();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the title of the view model.
        /// </summary>
        /// <value>The title.</value>
        /// <summary>
        /// Gets or sets the property value.
        /// </summary>

        /// <summary>
        /// Gets or sets the property value.
        /// </summary>
        public ViewModelBase CurrentViewModel
        {
            get { return GetValue<ViewModelBase>(CurrentViewModelProperty); }
            set { SetValue(CurrentViewModelProperty, value); }
        }

        /// <summary>
        /// Register the CurrentViewModel property so it is known in the class.
        /// </summary>
        public static readonly PropertyData CurrentViewModelProperty = RegisterProperty("CurrentViewModel", typeof(ViewModelBase), null);
        // TODO: Register models with the vmpropmodel codesnippet
        // TODO: Register view model properties with the vmprop or vmpropviewmodeltomodel codesnippets
        #endregion

        #region Commands
        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets
        /// <summary>
        /// Gets the name command.
        /// </summary>
        /// <summary>
        /// Gets the name command.
        /// </summary>
        public Command HomeViewCommand { get; private set; }

        /// <summary>
        /// Method to check whether the name command can be executed.
        /// </summary>
        /// <returns><c>true</c> if the command can be executed; otherwise <c>false</c></returns>
        private bool OnHomeViewCommandCanExecute()
        {
            return !CurrentViewModel.GetType().Equals(typeof(HomeViewModel));
        }

        /// <summary>
        /// Method to invoke when the name command is executed.
        /// </summary>
        private void OnHomeViewCommandExecute()
        {
            // TODO: Handle command logic here
            CurrentViewModel = new HomeViewModel();
        }


        /// <summary>
        /// Gets the name command.
        /// </summary>
        public Command AddReport { get; private set; }


        /// <summary>
        /// Method to check whether the name command can be executed.
        /// </summary>
        /// <returns><c>true</c> if the command can be executed; otherwise <c>false</c></returns>
        private bool OnAddReportCanExecute()
        {
            return !CurrentViewModel.GetType().Equals(typeof(ReportViewModel));
        }

        /// <summary>
        /// Method to invoke when the name command is executed.
        /// </summary>
        private void OnAddReportExecute()
        {
            CurrentViewModel = new ReportViewModel();
        }

        #endregion

        #region Methods
        // TODO: Create your methods here
        #endregion
    }
}
