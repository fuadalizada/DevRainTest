using DevRainTest.Business.DTOs;

namespace DevRainTest.WebApi.ServiceFacades
{
    public class UserServiceFacade
    {
        public List<UserDto> InsertUserDatas()
        {
            var users = new List<UserDto>()
            {
                new UserDto(){Id = Guid.NewGuid(),Email="test@gmail.com",Name="Test",Surname="Testov"},
                new UserDto(){Id = Guid.NewGuid(),Email="test1@gmail.com",Name="Test1",Surname="Testov1"},
                new UserDto(){Id = Guid.NewGuid(),Email="test2@gmail.com",Name="Test2",Surname="Testov2"},
                new UserDto(){Id = Guid.NewGuid(),Email="test3@gmail.com",Name="Test3",Surname="Testov3"},
                new UserDto(){Id = Guid.NewGuid(),Email="test4@gmail.com",Name="Test4",Surname="Testov4"},
                new UserDto(){Id = Guid.NewGuid(),Email="test5@gmail.com",Name="Test5",Surname="Testov5"},
                new UserDto(){Id = Guid.NewGuid(),Email="test6@gmail.com",Name="Test6",Surname="Testov6"},
                new UserDto(){Id = Guid.NewGuid(),Email="test@gmail.com",Name="Test",Surname="Testov"},
                new UserDto(){Id = Guid.NewGuid(),Email="test1@gmail.com",Name="Test1",Surname="Testov1"},
                new UserDto(){Id = Guid.NewGuid(),Email="test3@gmail.com",Name="Test3",Surname="Testov3"},
                new UserDto(){Id = Guid.NewGuid(),Email="test4@gmail.com",Name="Test4",Surname="Testov4"},
                new UserDto(){Id = Guid.NewGuid(),Email="test6@gmail.com",Name="Test6",Surname="Testov6"},
                new UserDto(){Id = Guid.NewGuid(),Email="test@gmail.com",Name="Test",Surname="Testov"},
                new UserDto(){Id = Guid.NewGuid(),Email="test1@gmail.com",Name="Test1",Surname="Testov1"},
                new UserDto(){Id = Guid.NewGuid(),Email="test2@gmail.com",Name="Test2",Surname="Testov2"},
                new UserDto(){Id = Guid.NewGuid(),Email="test3@gmail.com",Name="Test3",Surname="Testov3"},
                new UserDto(){Id = Guid.NewGuid(),Email="test4@gmail.com",Name="Test4",Surname="Testov4"},
                new UserDto(){Id = Guid.NewGuid(),Email="test5@gmail.com",Name="Test5",Surname="Testov5"},
                new UserDto(){Id = Guid.NewGuid(),Email="test6@gmail.com",Name="Test6",Surname="Testov6"},
                new UserDto(){Id = Guid.NewGuid(),Email="test@gmail.com",Name="Test",Surname="Testov"},
                new UserDto(){Id = Guid.NewGuid(),Email="test1@gmail.com",Name="Test1",Surname="Testov1"},
                new UserDto(){Id = Guid.NewGuid(),Email="test3@gmail.com",Name="Test3",Surname="Testov3"},
                new UserDto(){Id = Guid.NewGuid(),Email="test4@gmail.com",Name="Test4",Surname="Testov4"},
                new UserDto(){Id = Guid.NewGuid(),Email="test6@gmail.com",Name="Test6",Surname="Testov6"},
                new UserDto(){Id = Guid.NewGuid(),Email="test@gmail.com",Name="Test",Surname="Testov"},
                new UserDto(){Id = Guid.NewGuid(),Email="test1@gmail.com",Name="Test1",Surname="Testov1"},
                new UserDto(){Id = Guid.NewGuid(),Email="test2@gmail.com",Name="Test2",Surname="Testov2"},
                new UserDto(){Id = Guid.NewGuid(),Email="test3@gmail.com",Name="Test3",Surname="Testov3"},
                new UserDto(){Id = Guid.NewGuid(),Email="test4@gmail.com",Name="Test4",Surname="Testov4"},
                new UserDto(){Id = Guid.NewGuid(),Email="test5@gmail.com",Name="Test5",Surname="Testov5"},
                new UserDto(){Id = Guid.NewGuid(),Email="test6@gmail.com",Name="Test6",Surname="Testov6"},
                new UserDto(){Id = Guid.NewGuid(),Email="test@gmail.com",Name="Test",Surname="Testov"},
                new UserDto(){Id = Guid.NewGuid(),Email="test1@gmail.com",Name="Test1",Surname="Testov1"},
                new UserDto(){Id = Guid.NewGuid(),Email="test3@gmail.com",Name="Test3",Surname="Testov3"},
                new UserDto(){Id = Guid.NewGuid(),Email="test4@gmail.com",Name="Test4",Surname="Testov4"},
                new UserDto(){Id = Guid.NewGuid(),Email="test6@gmail.com",Name="Test6",Surname="Testov6"},
                new UserDto(){Id = Guid.NewGuid(),Email="test@gmail.com",Name="Test",Surname="Testov"},
                new UserDto(){Id = Guid.NewGuid(),Email="test1@gmail.com",Name="Test1",Surname="Testov1"},
                new UserDto(){Id = Guid.NewGuid(),Email="test2@gmail.com",Name="Test2",Surname="Testov2"},
                new UserDto(){Id = Guid.NewGuid(),Email="test3@gmail.com",Name="Test3",Surname="Testov3"},
                new UserDto(){Id = Guid.NewGuid(),Email="test4@gmail.com",Name="Test4",Surname="Testov4"},
                new UserDto(){Id = Guid.NewGuid(),Email="test5@gmail.com",Name="Test5",Surname="Testov5"},
                new UserDto(){Id = Guid.NewGuid(),Email="test6@gmail.com",Name="Test6",Surname="Testov6"},
                new UserDto(){Id = Guid.NewGuid(),Email="test@gmail.com",Name="Test",Surname="Testov"},
                new UserDto(){Id = Guid.NewGuid(),Email="test1@gmail.com",Name="Test1",Surname="Testov1"},
                new UserDto(){Id = Guid.NewGuid(),Email="test3@gmail.com",Name="Test3",Surname="Testov3"},
                new UserDto(){Id = Guid.NewGuid(),Email="test4@gmail.com",Name="Test4",Surname="Testov4"},
                new UserDto(){Id = Guid.NewGuid(),Email="test6@gmail.com",Name="Test6",Surname="Testov6"}
            };
            return users;
        }             
    }
}
