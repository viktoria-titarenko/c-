//using MySql.Data.MySqlClient;

//string connect = "Database=tz1;Data Source=localhost;User Id=vika;Password=12345qwert";
//var myConnect = new MySqlConnection(connect);
//await myConnect.OpenAsync();
//string commandtext = "insert into test (name) values ('Misha');";
//MySqlCommand mycommand = new MySqlCommand(commandtext, myConnect);
//mycommand.ExecuteNonQuery();
//string select = "select name from test where id = 2";
//MySqlCommand command = new MySqlCommand(select, myConnect);
//string answer = command.ExecuteScalar().ToString();
//Console.WriteLine(answer);
//Console.WriteLine(myConnect.State);

using MySqlX.XDevAPI.Relational;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using VkNet;
using VkNet.Abstractions.Utils;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.RequestParams;

var api = new VkApi();
api.Authorize(new ApiAuthParams
{
    Login = "89832318494",
    Password = "25idredwest",
    AccessToken = "vk1.a.KA6_Wye8jFR4ZaHpLC6X1icnsSxrEq0A-NhgfYcPICyTp6_LdkJaddqaa8BOWQjZvv0CrJcEUhBt_b1-HXSEhbH4u3YXuMNv-JpmP7wNnD2pmT13kW1K4lLDLkkQ8mDcdEqyyFUqcn4qkIBnve4ULPSVEZlIrlk3lBOjrplshJti24ywxaS930e0FoTWsgM3"
});

var ids = api.Groups.GetMembers(new GroupsGetMembersParams() { GroupId = "pfc_cska1911" }).Select(u => u.Id).ToList();
var count = 0;
Console.WriteLine(count);
var result = new Dictionary<long,long>();
var result2 = new Dictionary<long,long>();

//for (ulong i = 0; i < 5000; i += 1000)
//{
  //  Console.WriteLine(i);
    //var member = api.Groups.GetMembers(new GroupsGetMembersParams()
    //{
      //  GroupId = "pfc_cska1911",
      // Offset = (long)i
    //});
    //for (int k = 0; k < member.Count; k++)
    //{
      //  result.Add(member[k].Id, 1);
    //}
    //await Task.Delay(2000);
//}
var idss = api.Groups.IsMember(groupId: "army_mems", userId: null, userIds: ids, extended: true).Where(f => f.Member).ToList();
foreach (var id in idss)
{
    Console.WriteLine(id.UserId);
}

///var ids_second = api.Groups.GetMembers(new GroupsGetMembersParams() { GroupId = "army_mems", Fields = UsersFields.All });
//var count_second = ids_second.TotalCount;
//for (ulong i = 0; i < count_second; i+=1000)
//{
//  Console.WriteLine($"bbb{i}");
//var member_second = api.Groups.GetMembers(new GroupsGetMembersParams()
//{
//      GroupId = "army_mems",
//    Offset = (long)i
//});
//for (int k = 0; k < member_second.Count; k++)
//   {
//     if (result.ContainsKey(member_second[k].Id))
//   {
//     result2.Add(member_second[k].Id,1);
//}
// }
//  await Task.Delay(2000);

//}
//Console.WriteLine(result2.Count);