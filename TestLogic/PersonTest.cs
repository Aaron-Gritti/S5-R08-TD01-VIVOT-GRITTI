using Logic;

namespace TestLogic
{
    public class PersonTest
    {
        [Fact]
        public void TestCreate()
        {
            Person p = new Person();
            Assert.Equal(0, p.Id);
            Assert.Equal("", p.Name);
            Assert.Equal("", p.Phone);
        }

        [Fact]
        public void TestSetName()
        {
            Person p = new Person();
            string name = "toto";
            p.Name = name;
            Assert.Equal(name, p.Name);
        }

        [Fact]
        public void TestSetPhone()
        {
            Person p = new Person();
            string phone = "01-02-03-04-05";
            p.Phone = phone;
            Assert.Equal(phone, p.Phone);
        }
    }
}