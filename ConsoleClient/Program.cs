using Newtonsoft.Json;
using MyMessanger;

Message msg = new Message("Tony", "Privet", DateTime.UtcNow);
string output = JsonConvert.SerializeObject(msg);
Console.WriteLine(output);
Message deserializeMsg = JsonConvert.DeserializeObject<Message>(output);
Console.WriteLine(deserializeMsg);

/*{ "UserName":"Tony","MessageText":"Privet","TimeStamp":"2022-10-02T10:31:51.10571Z"}
Tony < 02.10.2022 10:31:51 >: Privet*/



