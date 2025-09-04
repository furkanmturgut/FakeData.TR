using FakeData.TR.Resources;

namespace FakeData.TR
{
    public static class FakeData
    {
        private static readonly Random _random = new();

        public static string FirstName()
            => FirstNames.Data[_random.Next(FirstNames.Data.Count)];

        public static string LastName()
            => LastNames.Data[_random.Next(LastNames.Data.Count)];

        public static string FullName()
            => $"{FirstName()} {LastName()}";

        public static string City()
            => Cities.Data[_random.Next(Cities.Data.Count)];

        public static string PhoneNumber()
        {
            // 05xx xxx xx xx formatı
            var prefix = _random.Next(500, 599);
            return $"0{prefix} {_random.Next(100, 999)} {_random.Next(10, 99)} {_random.Next(10, 99)}";
        }

        public static string TCIdentity()
        {
            var digits = new int[11];
            digits[0] = _random.Next(1, 10);
            for (int i = 1; i < 9; i++)
                digits[i] = _random.Next(0, 10);

            digits[9] = ((digits[0] + digits[2] + digits[4] + digits[6] + digits[8]) * 7
                         - (digits[1] + digits[3] + digits[5] + digits[7])) % 10;
            digits[10] = (digits.Take(10).Sum()) % 10;

            return string.Join("", digits);
        }

        public static string Email()
        {
            var name = FirstName().ToLower();
            var surname = LastName().ToLower();
            var domain = new[] { "gmail.com", "outlook.com", "yahoo.com", "hotmail.com" }[_random.Next(4)];
            return $"{name}.{surname}{_random.Next(10, 99)}@{domain}";
        }

        public static DateTime BirthDate()
        {
            var start = new DateTime(1950, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(_random.Next(range));
        }

        public static string Country()
            => Countries.Data[_random.Next(Countries.Data.Count)];

        public static string Company()
            => Companies.Data[_random.Next(Companies.Data.Count)];

        public static string Address()
        {
            return FullAddresses.Data[_random.Next(FullAddresses.Data.Count)];
        }

        public static string Product()
        {
            return Products.Data[_random.Next(Products.Data.Count)];
        }

        public static string Title()
        {
            return Titles.Data[_random.Next(Titles.Data.Count)];
        }

        public static string Content()
        {
            return BlogContents.Data[_random.Next(BlogContents.Data.Count)];
        }

        public static string Website()
        {
            return Websites.Data[_random.Next(Websites.Data.Count)];
        }

        public static string EmailRandom()
        {
            return Emails.Data[_random.Next(Emails.Data.Count)];
        }

        public static string Username()
        {
            return Usernames.Data[_random.Next(Usernames.Data.Count)];
        }

        public static string Profession()
        {
            return Professions.Data[_random.Next(Professions.Data.Count)];
        }

        public static string Department()
        {
            return Departments.Data[_random.Next(Departments.Data.Count)];
        }
    }
}
