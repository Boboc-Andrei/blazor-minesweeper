using System;
using System.Collections.Generic;
using System.Linq;

namespace MinesweeperDotNET.Game
{
    public interface IDifficultyLoader
    {
        public Dictionary<Difficulty, DifficultySettings> Load();
    }

    public class MockJsonDifficultyLoader : IDifficultyLoader
    {
        public MockJsonDifficultyLoader() { }

        public Dictionary<Difficulty, DifficultySettings> Load()
        {
            //TODO
            return new()
            {
                {
                    Difficulty.Easy,
                    new DifficultySettings()
                    {
                        Name = "Easy",
                        Rows = 9,
                        Cols = 9,
                        Mines = 10,
                    }
                },
                {
                    Difficulty.Medium,
                    new DifficultySettings()
                    {
                        Name = "Medium",
                        Rows = 16,
                        Cols = 16,
                        Mines = 40,
                    }
                },
                {
                    Difficulty.Hard,
                    new DifficultySettings()
                    {
                        Name = "Hard",
                        Rows = 16,
                        Cols = 30,
                        Mines = 99,
                    }
                },
                {
                    Difficulty.Extreme,
                    new DifficultySettings()
                    {
                        Name = "Extreme",
                        Rows = 24,
                        Cols = 30,
                        Mines = 160,
                    }
                },
            };
        }
    }
}
