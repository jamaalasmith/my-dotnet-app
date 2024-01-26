
namespace my_dotnet_app.Services
{
    public class usersService
    {
        public List<User> getAll()
        {

            List<User> list = [];

            User jamaal = new()
            {
                Id = 1,
                Firstname = "Jamaal",
                Lastname = "Smith"
            };
            User nick = new()
            {
                Id = 2,
                Firstname = "Nick",
                Lastname = "Mclean"
            };
            User cindy = new()
            {
                Id = 4,
                Firstname = "Cindy",
                Lastname = "Carrillo"
            };
            User troy = new()
            {
                Id = 3,
                Firstname = "Troy",
                Lastname = "Sparks"
            };
            User tin = new()
            {
                Id = 5,
                Firstname = "Tin",
                Lastname = "Dang"
            };

            list.Add(jamaal);
            list.Add(cindy);
            list.Add(nick);
            list.Add(troy);
            list.Add(tin);

            return list;
        }
    }
}