using Microsoft.Extensions.Logging;
using System;

namespace OtrippleS.Portal.Web.Brokers.Logging
{
    public class LoggingBroker : ILoggingBroker
    {
        private readonly ILogger _logger;

        public LoggingBroker(ILogger logger) => this._logger = logger;

        public void LogCritical(Exception exception) =>
            this._logger.LogCritical(exception, exception.Message);

        public void LogDebug(string message) =>
            this._logger.LogDebug(message);

        public void LogError(Exception exception) =>
            this._logger.LogError(exception, exception.Message);

        public void LogInformation(string message) =>
            this._logger.LogInformation(message);

        public void LogTrace(string message) =>
            this._logger.LogTrace(message);

        public void LogWarning(string message) =>
            this._logger.LogWarning(message);
    }
}
