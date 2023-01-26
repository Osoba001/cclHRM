using AutoMapper;
using HRMS.Application.AuthenticateRefreshToken;
using HRMS.Auth;
using HRMSapplication.Response;
using MediatR;

namespace HRMS.Application.Handlers.Authentication.AuthenticateRefreshToken
{
    public record AuthenticateRefreshTokenQuery(string RefreshToken) : IRequest<TokenModel>;
}
