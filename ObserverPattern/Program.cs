using ObserverPattern;

YoutubeChannel channel = new YoutubeChannel();

//Create subscribers
ISubscriber ananya = new Ananya();
ISubscriber amol = new Amol();

//Add subscribers to the channel
channel.AddSubscriber(ananya);
channel.AddSubscriber(amol);

//Upload a video
channel.UploadVideo("Video1");