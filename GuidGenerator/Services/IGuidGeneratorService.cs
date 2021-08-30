using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuidGenerator.Services
{
    public interface IGuidGeneratorService
    {
        public List<Guid> GenerateGuids(int numberOfGuids);
    }
}
