﻿namespace Restaurent.API
{
    public class BackGroundMicroService : BackgroundService, IHostedService
    {
        private readonly ILogger<BackGroundMicroService> _logger;

        public BackGroundMicroService(ILogger<BackGroundMicroService> logger)
        {
            _logger = logger;
        }

        public Task StartedAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Background service started.");
            return Task.CompletedTask;
        }

        public Task StartingAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Background service starting.");
            return Task.CompletedTask;
        }

        public Task StoppedAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Background service stopped.");
            return Task.CompletedTask;
        }

        public Task StoppingAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Background service stopping.");
            return Task.CompletedTask;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Background service is executing.");

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}
