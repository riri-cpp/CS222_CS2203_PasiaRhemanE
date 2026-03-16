SmartPhone sp = new SmartPhone();
sp.takePhoto();
sp.playMusic();
sp.sendMessage();

Console.WriteLine();

Computer pc = new Computer();
pc.playMusic();
pc.sendMessage();

interface ICamera
{
    void takePhoto();
}

interface IMusicPlayer
{
    void playMusic();
}

interface IMessenger
{
    void sendMessage();
}

class SmartPhone : ICamera, IMusicPlayer, IMessenger
{
    public void takePhoto()
    {
        Console.WriteLine("Taking a photo...");
    }
    public void playMusic()
    {
        Console.WriteLine("Playing music...");
    }
    public void sendMessage()
    {
        Console.WriteLine("Sending a message...");
    }
}
class Computer : IMusicPlayer, IMessenger
{
    public void playMusic()
    {
        Console.WriteLine("Playing music on computer...");
    }
    public void sendMessage()
    {
        Console.WriteLine("Sending a message from computer...");
    }
}