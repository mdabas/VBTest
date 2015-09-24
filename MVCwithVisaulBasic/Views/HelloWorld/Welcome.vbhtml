@Code
    ViewBag.Title = "Welcome"
End Code
<h2>Welcome</h2>

<ul>
    @For i = 1 To ViewBag.NumTimes
        @<li>@ViewBag.Message : cheers</li> ' Manish added cheers - Sep24, 2015
        @<li>@i times</li> 

    Next
</ul>
