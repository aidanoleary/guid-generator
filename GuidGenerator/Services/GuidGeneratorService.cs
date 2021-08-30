using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuidGenerator.Services
{
    public class GuidGeneratorService : IGuidGeneratorService
    {
        public List<Guid> GenerateGuids(int numberOfGuids = 1)
        {
            List<Guid> generatedGuids = new List<Guid>();
            for(int i = 0; i < numberOfGuids; i++)
            {
                generatedGuids.Add(Guid.NewGuid());
            }
            return generatedGuids;
        }
    }
}
