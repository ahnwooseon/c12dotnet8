using System.Diagnostics;

string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");

WriteLine($"Writing to: {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

#if DEBUG
// Text writer is buffered, so this option calls
// Flush() on all listeners after writing. Trace.AutoFlush = true;
Trace.AutoFlush = true;
#endif

Debug.WriteLine("Debug says, I am watching");
Trace.WriteLine("Trace says, I am watching");

// Close the text file (also flushes) and release resources.
Debug.Close();
Trace.Close();
