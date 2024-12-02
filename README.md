# TimeTracker
A time management app I worked on in my spare time.

I wrote this app in about 5 hours, but the idea was to have multiple stopwatches you could use to keep a running total of how many hours you dedicate to a specific task in a week. That doesn't have to be the ONLY way it can be used, but it was the thought coming in.
The problem is going to be distributing it. As I was testing out the possibility of distributing this on my website, it started talking about it being a Trojan. I'm not sure whether this is a false flag or a possible MitM attack due to the lack of an SSL certificate on my website. Either way it's cause for concern.

I want to upload the installer for the program here. I will also share the source code for the project as well so people can see it and give feedback through any sort of channel. I had to look up a bunch of resources, but Shaun Halverson's stopwatch tutorial was the most help. You can view it here. https://youtu.be/tdiXcOjcO0o?si=3ITY7UasWFrIGWMh

Naturally I made some modifications of my own. There is only 1 button that starts and stops the timers. Also, the timer is selected based on the day of the week, but you can override it if needed. I included some file input/output so you can save your weekly totals between sessions and look them up later. I don't know if the file extension is used by anything else, I simply chose rkf, but it's a simple plaintext file. I hope it isn't associated with anything else.

That's all I have to say about it for now.
