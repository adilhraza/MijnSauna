﻿using Microsoft.Extensions.DependencyInjection;
using MijnSauna.Backend.DataAccess.DependencyInjection;
using MijnSauna.Backend.Logic.Interfaces;
using MijnSauna.Backend.Logic.Validation;
using MijnSauna.Backend.Logic.Validation.Interfaces;
using MijnSauna.Backend.Mappers.DependencyInjection;
using MijnSauna.Common.DataTransferObjects.Sessions;

namespace MijnSauna.Backend.Logic.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureLogic(this IServiceCollection serviceCollection)
        {
            serviceCollection.ConfigureDataAccess();
            serviceCollection.ConfigureMappers();
            serviceCollection.AddTransient<ISessionLogic, SessionLogic>();
            serviceCollection.AddSingleton<IValidator<CreateSessionRequest>, CreateSessionRequestValidator>();
        }
    }
}