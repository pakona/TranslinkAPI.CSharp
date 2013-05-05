TranslinkAPI.CSharp
===================

.Net API to access Translink's bus schedules data.

- .Net Portable Class Library (the binary can be reused on multiple platforms, including Windows Phone and Windows Store Apps)
- Asynchronous (async/await)
- Light and easy to use
- Very well documented
- Exposes every single API available through Translink's Restfull API V1

Usage example:
--------------------
//get informations about stop 51549                                   
GetStopResponse rsp = await Translink.GetStop("Your_API_Key", 51549);                  
Console.WriteLine(rsp.Stop.Name);
