
using FeeCalculator.Core.Services;

namespace FeeCalculator.Services
{
    public class LoggerService : ILoggerService
    {
        #region Variables


        #endregion

        #region Constructor


        #endregion

        #region Public methods

        public void AddFileLog(string source, string desc)
        {
            try
            {
                //ProcessLogHandler.AddLogMessage(source + " ; " + desc, ProcessLogHandler.PlaceLog.Both, ProcessLogHandler.EventLogType.Error);
            }
            catch { }
        }
        #endregion

        #region Private methods


        #endregion
    }
}
