using SimpleApp.Models;

namespace SimpleApp.Tests {
    public class ProdcutTests {

        [Fact]
        public void CanChangeProdcutName(){
            var p = new Product { Name = "Tests", Price = 100M };
            p.Name = "New Name";
            Assert.Equal("New Name", p.Name);
        }

        [Fact]
        public void CanChangeProdcutPrice(){
            var p = new Product { Name = "Tests", Price = 100M };
            p.Price = 200M;
            Assert.Equal(200M, p.Price);
        }
    }
}