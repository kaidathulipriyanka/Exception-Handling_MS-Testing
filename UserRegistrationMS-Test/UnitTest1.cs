using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_Exception_Validation;

namespace UserRegistrationMS_Test
{
    [TestClass]
    public class UserRegistrationTests
    {
        [TestMethod]
        public void TestFirstNameValidation()
        {
            UserRegistration registration = new UserRegistration();
            Assert.IsTrue(registration.ValidateFirstName("John"));
            Assert.IsFalse(registration.ValidateFirstName("j"));
        }

        [TestMethod]
        public void TestLastNameValidation()
        {
            UserRegistration registration = new UserRegistration();
            Assert.IsTrue(registration.ValidateLastName("Doe"));
            Assert.IsFalse(registration.ValidateLastName("d"));
        }

        [TestMethod]
        public void TestEmailValidation()
        {
            UserRegistration registration = new UserRegistration();
            Assert.IsTrue(registration.ValidateEmail("abc.xyz@bl.co.in"));
            Assert.IsFalse(registration.ValidateEmail("invalid.email"));
        }

        [TestMethod]
        public void TestMobileNumberValidation()
        {
            UserRegistration registration = new UserRegistration();
            Assert.IsTrue(registration.ValidateMobileNumber("91 9919819801"));
            Assert.IsFalse(registration.ValidateMobileNumber("12345"));
        }

        [TestMethod]
        public void TestPasswordValidation()
        {
            UserRegistration registration = new UserRegistration();
            Assert.IsTrue(registration.ValidatePassword("Password1@"));
            Assert.IsFalse(registration.ValidatePassword("weak"));
        }
    }
}