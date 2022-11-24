
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using VkNet;
using VkNet.Abstractions.Utils;
using VkNet.AudioBypassService.Extensions;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Utils;

var services = new ServiceCollection();
services.AddAudioBypass();

var api = new VkApi(services);
api.Authorize(new ApiAuthParams
{
    Login = "89832318494",
    Password = "25idredwest",
    AccessToken = "vk1.a.0ueg-3wSf6Oyjd8dsVOqzCXAI_o7umZ6nmjZ4Uy-o77m4UUG43WYSyXclE8KfV4ffmdLUehYCkrE9MZmcI4kVn5RfVrX5LLtwpsaPILoGovkp1R1w7wTXxRpLuFSNf7JWdMyuOSmqVUEf6EBPLhi-9rTop3Qzw7Y9ZBzYlfsczREYN2VmF0tW83j61xYUbJK"
});
var friendss = getfriends(api);
Console.WriteLine("Выберите номер друга и напишите его ниже");
var id= int.Parse(Console.ReadLine());
var id_need = friendss[id - 1].Id;
var idd = new AudioGetParams {OwnerId = id_need };
getAudio(id_need, api);

VkCollection<User> getfriends(VkApi i)
{
    var friends = i.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams
    {
        Fields = ProfileFields.FirstName | ProfileFields.LastName,
        Count = 40,
    }); ;
    var friends_list = friends.Select(x=>$"{x.FirstName} " + $"{x.LastName}").ToList();
    
    for(var friend=0; friend<friends_list.Count; friend++)
    {
        Console.WriteLine($"№{friend+1}) {friends_list[friend]}");
    }
    return friends;
}
void getAudio(long id, VkApi i)
{
    Console.WriteLine(id);
    var ID = new AudioGetParams { OwnerId = id, Count=10 };
    var audios = i.Audio.Get(ID);
    
    foreach (var audio in audios)
    {
        Console.WriteLine(audio);
    }
}

 