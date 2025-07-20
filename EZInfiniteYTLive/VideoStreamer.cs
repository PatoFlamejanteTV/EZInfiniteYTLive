using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

namespace EZInfiniteYTLive
{
    public class VideoStreamer : IDisposable
    {
        private readonly string _ffmpegPath;
        private readonly string _videoFolder;
        private readonly string _rtmpUrl;
        private readonly string[] _videoExtensions = { ".mp4", ".mkv", ".avi", ".mov", ".flv" };
        private Thread _streamThread;
        private bool _stopRequested;
        private Process _ffmpegProcess;

        public VideoStreamer(string ffmpegPath, string videoFolder, string rtmpUrl)
        {
            _ffmpegPath = ffmpegPath;
            _videoFolder = videoFolder;
            _rtmpUrl = rtmpUrl;
        }

        public void StartStreaming()
        {
            if (_streamThread != null && _streamThread.IsAlive)
                return;
            _stopRequested = false;
            _streamThread = new Thread(StreamVideos) { IsBackground = true };
            _streamThread.Start();
        }

        public void StopStreaming()
        {
            _stopRequested = true;
            try
            {
                if (_ffmpegProcess != null && !_ffmpegProcess.HasExited)
                {
                    _ffmpegProcess.Kill();
                }
            }
            catch { }
        }

        private void StreamVideos()
        {
            var files = Directory.GetFiles(_videoFolder)
                .Where(f => _videoExtensions.Contains(Path.GetExtension(f), StringComparer.OrdinalIgnoreCase))
                .OrderBy(f => f)
                .ToList();
            if (!files.Any())
                return;
            int idx = 0;
            while (!_stopRequested)
            {
                string file = files[idx];
                RunFfmpeg(file);
                idx = (idx + 1) % files.Count; // Loop
            }
        }

        private void RunFfmpeg(string inputFile)
        {
            var args = $"-re -stream_loop 1 -i \"{inputFile}\" -c copy -f flv \"{_rtmpUrl}\"";
            var psi = new ProcessStartInfo
            {
                FileName = _ffmpegPath,
                Arguments = args,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };
            using (var process = new Process { StartInfo = psi })
            {
                _ffmpegProcess = process;
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();
            }
        }

        public void Dispose()
        {
            StopStreaming();
        }
    }
}
