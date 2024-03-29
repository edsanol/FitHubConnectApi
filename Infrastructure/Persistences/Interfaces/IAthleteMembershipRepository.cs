﻿using Domain.Entities;
using Infrastructure.Commons.Bases.Response;

namespace Infrastructure.Persistences.Interfaces
{
    public interface IAthleteMembershipRepository
    {
        Task<bool> RegisterAthleteMembership(AthleteMembership athleteMembership);
        Task<IEnumerable<DashboardGraphicsResponse>> GetIncome(int gymID, DateOnly startDate, DateOnly endDate);
    }
}
