namespace Packt.Shared;

public interface IPlayable
{
    void Play();
    void Pause();
    void Stop() // Default implementation
    {
        WriteLine("Default implementation of Stop.");
    }
}
