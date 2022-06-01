namespace WebEmptyTemplate.Data.Models.CsModels.Components
{
    /// <summary>
    /// Материнская плата.
    /// </summary>
    public class Motherboard : Part
    {
        #region Supported CPU
        /// <summary>
        /// Сокет.
        /// </summary>
        public string CPUSocket { get; set; }
        /// <summary>
        /// Список поддерживаемых процессоров.
        /// </summary>
        public IList<string> CPUType { get; set; }
        #endregion //end Supported CPU

        #region Chipset
        public string Chipset { get; set; }
        #endregion //end Chipset

        #region Memory
        /// <summary>
        /// Тип оперативной памяти.
        /// </summary>
        public string MemoryType { get; set; }
        /// <summary>
        /// Минимальная частота оперативной памяти.
        /// </summary>
        public int MemoryMinFrequency { get; set; }
        /// <summary>
        /// Максимальная частота оперативной памяти.
        /// </summary>
        public int MemoryMaxFrequence { get; set; }
        /// <summary>
        /// Количество слотов памяти.
        /// </summary>
        public int MemoryNumberOfSlots { get; set; }
        /// <summary>
        /// Максимальный объем поддерживаемой памяти.
        /// </summary>
        public int MemoryMaxSize { get; set; }
        /// <summary>
        /// Поддержка двухканального режима.
        /// </summary>
        public bool DualMode { get; set; }
        #endregion //end Memory

        #region Audio
        /// <summary>
        /// Аудио чипсет.
        /// </summary>
        public string AudioChipset { get; set; }
        /// <summary>
        /// Количество аудио-каналов.
        /// </summary>
        public int AudioChannels { get; set; }
        #endregion //end Audio

        #region Networking
        /// <summary>
        /// Сетевой чипсет.
        /// </summary>
        public string LANChipset { get; set; }
        /// <summary>
        /// Максимальная скорость обмена, Mbps.
        /// </summary>
        public int LANMaxSpeed { get; set; }
        #endregion //end Networking
    }
}
