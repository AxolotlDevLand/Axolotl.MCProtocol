﻿namespace Axolotl.Util;

public class Experiments : List<Experiments.Experiment>
    {
        public class Experiment
            {
                public Experiment(string name, bool enabled)
                    {
                        Name = name;
                        Enabled = enabled;
                    }

                public string Name { get; }
                public bool Enabled { get; }
            }
    }