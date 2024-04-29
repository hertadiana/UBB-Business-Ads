﻿namespace UBB_Business_Ads.Tests.Test_models
{
    using Backend.Models;

    [TestFixture]
    internal class UserModelTest
    {
        [Test]
        public void User_PropertiesAreSetCorrectly()
        {
            string username = "testuser";
            string password = "testpass";
            string email = "testuser@example.com";

            User user = new User
            {
                Username = username,
                Password = password,
                Email = email,
            };
            Assert.That(user.Username, Is.EqualTo(username));
            Assert.That(user.Email, Is.EqualTo(email));
            Assert.That(user.Password, Is.EqualTo(password));
        }
    }
}