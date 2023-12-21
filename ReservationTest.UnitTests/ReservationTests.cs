using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleTest.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        private Reservation _reservation;

        private User _user;
        private User _notGoodUser;


        [TestInitialize]
        public void Init()
        {

            // Arrange
            _user = new User();
            _user.IsAdmin = true;
            _reservation = new Reservation(_user);
            _notGoodUser = new User();
            


        }

        [TestMethod]
        public void CanBeCancelledBy_WhenReservationIsCancelledByGoodUser_ReturnTrue()
        {
            // Act
            var result = _reservation.CanBeCancelledBy(_user);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_WhenReservationIsCancelledByNotGoodUser_ReturnFalse()
        {
            _notGoodUser.IsAdmin = false;
            // Act
            var result = _reservation.CanBeCancelledBy(_notGoodUser);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_WhenReservationIsCancelledByAdminUser_ReturnTrue()
        {
            _notGoodUser.IsAdmin = true;
            // Act
            var result = _reservation.CanBeCancelledBy(_notGoodUser);

            // Assert
            Assert.IsTrue(result);
        }
    }
}