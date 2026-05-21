import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44346/',
  redirectUri: baseUrl,
  clientId: 'AbpSolution5_App',
  responseType: 'code',
  scope: 'offline_access AbpSolution5',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'AbpSolution5',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44346',
      rootNamespace: 'AbpSolution5',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
