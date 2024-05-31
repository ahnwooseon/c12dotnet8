using Packt.Shared; // To use Viper.

SectionTitle("Writing to text streams");

// Define a file to write to.
string textFile = Combine(CurrentDirectory, "streams.txt");

// Create a text file and return a helper writer.
StreamWriter text = File.CreateText(textFile);

// Enumerate the strings, writing each one to the stream on a separate line.
foreach (string item in Viper.Callsigns)
{
    text.WriteLine(item);
}

text.Close(); // Release unmanaged file resources.

OutputFileInfo(textFile);
