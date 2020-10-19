import { Config } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'EmployeeMangementSystem',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44330',
    redirectUri: baseUrl,
    clientId: 'EmployeeMangementSystem_App',
    responseType: 'code',
    scope: 'offline_access EmployeeMangementSystem',
  },
  apis: {
    default: {
      url: 'https://localhost:44330',
      rootNamespace: 'EmployeeMangementSystem',
    },
  },
} as Config.Environment;
