# VKScript
Script language to make VK API calls made with Antlr and C#

### Example script

```VKScript
// === This script will send message Hi to logged in user ===

vk = login(user: "username@email.com", pswd: "somepassword")     //login as user

if (vk == "success") {                                           // if logged in
	myData = usersGet()                                          // get info about current user
	sleep(300)                                                   // sleep for 300 ms because vk api 
	                                                             // limits number of requests per second
	myId = myData.byKey("response").first().byKey("uid")         // fetch current user id
	print("my id: " + myId)                                      // print current user id
	res = messagesSend(user_id: myId, message: "Hi")             // send message to current user
	print("message id: " + res)                                  // print response
} else {
	print("wrong username/password")
}
```

Save this code snippet to file and pass file path to VKScript.exe as a command-line argument.

You can also user interactive mode, simply run VKScript.exe without any command-line arguments:

```VKScript
>>> login(user: "username@email.com", pswd: "somepassword")
success
>>> myData = usersGet()
>>> myData
{response : {{uid : 12345678, first_name : Vasya, last_name : Sidorov}}}
>>> myId = myData.byKey("response").first().byKey("uid")
>>> myId
12345678
>>> messagesSend(user_id: myId, message: "Hi")
{response : 123456}
```

### Implemented features
- Math operators (`+`, `-`, `*`, `/`, `%`)
- Logical operators (`&&`, `||`)
- Comparison operators (`==`, `!=`, `<`, `<=`, `>`, `>=`)
- Expressions with brackets and operators priority
- `if`(-`else`) conditional operator
- `while` loop
- Dynamic typing with 5 variable types: `int`, `string`, `bool`, `pair` and `list` (+ casting)
- Chained function calls
- VK API calls with arbitrary arguments


### Version
1.0.0

### Tech

VKScript uses third-party projects to work properly:

* [Json.NET] - JSON framework for .NET
* [ANTLR] - parser generator

### Installation

`gen.cmd` to generate .cs files from ANTLR grammar

`make.cmd`* to copy .cs files to Visual Studio project folder and to build solution using MSBuild

`test.cmd`* to run unit tests using MSTest

\*you need to set PATH environment variable properly to use MSBuild and MSTest

### Todos

- Make assignment an `expr`
- Make pair an `expr : expr` (now `id : expr`)
- Consider `ID` as string literal if it is not initialized

License
----

GPL3


[Json.NET]: <http://www.newtonsoft.com/json>
[ANTLR]: <http://www.antlr.org>
