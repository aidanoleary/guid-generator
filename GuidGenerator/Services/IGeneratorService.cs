using System;
using System.Collections.Generic;

namespace GuidGenerator.Services
{
    public interface IGeneratorService
    {
        List<Guid> GenerateGuids(int amount);
        List<string> GenerateEmails(int amount);
        List<string> GenerateLatitudeLongitude(int amount);
        List<string> GenerateNames(int amount);
    }
}
