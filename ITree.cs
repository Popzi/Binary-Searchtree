namespace SortedTree
{
    /// <summary>
    /// Gränssnitt med metoder för ett binärt sökträd.
    /// 
    /// Programmerare: Hans-Edy Mårtensson
    /// Datum: 2019-05-11
    /// </summary>
    public interface ITree
    {
        /// <summary>
        /// Antal noder i trädet.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Lägge till en nod i trädet.
        /// </summary>
        /// <param name="key">Den söknyckel som hör till värdet</param>
        /// <param name="value">Det värde som ska sparas i trädet</param>
        void Add(string key, int value);

        /// <summary>
        /// Skriver ut innehållet alla noder i nycklarnas
        /// bokstavsordning till en listbox.
        /// </summary>
        /// <param name="listbox">Den listbox till vilket utskriften ska ske</param>
        void Traverse(System.Windows.Forms.ListBox listbox);

        /// <summary>
        /// Returnerar true eller false beroende på om trädet
        /// innehåller en nod vars nyckel överenstämmer med key.
        /// </summary>
        /// <param name="key">key är nyckeln till den sökta noden</param>
        /// <returns>true om noden finns, i annat fall false</returns>
        bool Contains(string key);

        /// <summary>
        /// Returnerar det värde som hör till söknyckeln.
        /// Om värdet inte finns returneras i stället ett
        /// dummy-värde.
        /// </summary>
        /// <param name="Key">Värdets söknyckel</param>
        /// <param name="dummy">Returneras om det sökta värdet saknas</param>
        /// <returns>det sökta värdet</returns>
        int Get(string key, int dummy = -1);

        /// <summary>
        /// Ersätter nodens värde med newValue
        /// </summary>
        /// <param name="key">Värdets söknyckel</param>
        /// <param name="newValue">Det nya värdet</param>
        void Set(string key, int newValue);

        /// <summary>
        /// Tar bor noden som vars söknyckel överensstämmer
        /// med key.
        /// </summary>
        /// <param name="key">Nyckel till den nod som ska tas bort</param>
        void Remove(string key);

        /// <summary>
        /// Returnerar trädets höjd.
        /// </summary>
        /// <returns>Trädets höjd</returns>
        int Height();

        /// <summary>
        /// Skriver ut innehållet alla noder i nycklarnas
        /// bokstavsordning till en textfil.
        /// </summary>
        /// <param name="fileName">Namnet på textfilen</param>
        void Traverse(string fileName);

    }
}