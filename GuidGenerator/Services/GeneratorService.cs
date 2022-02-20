using Bogus;
using System;
using System.Collections.Generic;

namespace GuidGenerator.Services
{
    public class GeneratorService : IGeneratorService
    {
        private readonly Faker faker;

        public GeneratorService()
        {
            this.faker = new Faker();
        }

        public List<string> GenerateEmails(int amount)
        {
            return Generate<string>(amount, () => faker.Internet.Email());
        }

        public List<Guid> GenerateGuids(int amount = 1)
        {
            return Generate<Guid>(amount, () => Guid.NewGuid());
        }

        public List<string> GenerateLatitudeLongitude(int amount)
        {
            return Generate<string>(amount, () => $"{faker.Address.Latitude()}:{faker.Address.Longitude()}");
        }

        public List<string> GenerateNames(int amount)
        {
            return Generate<string>(amount, () => faker.Name.FullName());
        }

        private List<TDataType> Generate<TDataType>(int amount, Func<TDataType> generatorFunction) 
        {
            List<TDataType> generatedItems = new List<TDataType>();
            for (int i = 0; i < amount; i++)
            {
                generatedItems.Add(generatorFunction());
            }
            return generatedItems;

        }
    }
}
