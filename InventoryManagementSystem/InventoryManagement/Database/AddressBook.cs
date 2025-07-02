using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Database
{
    internal static class AddressBook
    {
        public static readonly Dictionary<string, List<string>> addresses = new Dictionary<string, List<string>>
        {
            // Bagerhat
            {"Bagerhat", new List<string>{"Fakirhat", "Sadar", "Mollahat", "Sarankhola", "Rampal", "Morrelganj", "Kachua", "Mongla", "Chitalmari"}},
            
            // Bandarban
            {"Bandarban", new List<string>{"Sadar", "Alikadam", "Naikhongchhari", "Rowangchhari", "Lama", "Ruma", "Thanchi"}},
            
            // Barishal
            {"Barguna", new List<string>{"Amtali", "Sadar", "Betagi", "Bamna", "Pathorghata", "Taltali"}},
            
            // Barishal
            {"Barisal", new List<string>{"Barishalsadar", "Bakerganj", "Babuganj", "Wazirpur", "Banaripara", "Gournadi", "Agailjhara", "Mehendiganj", "Muladi", "Hizla"}},
            
            // Bhola
            {"Bhola", new List<string>{"Sadar", "Borhanuddin", "Charfesson", "Doulatkhan", "Monpura", "Tazumuddin", "Lalmohan"}},
            
            // Bogura
            {"Bogura", new List<string>{"Kahaloo", "Sadar", "Shariakandi", "Shajahanpur", "Dupchanchia", "Adamdighi", "Nondigram", "Sonatala", "Dhunot", "Gabtali", "Sherpur", "Shibganj"}},
            
            // Brahmanbaria
            {"Brahmanbaria", new List<string>{"Sadar", "Kasba", "Nasirnagar", "Sarail", "Ashuganj", "Akhaura", "Nabinagar", "Bancharampur", "Bijoynagar"}},
            
            // Chandpur
            {"Chandpur", new List<string>{"Haimchar", "Kachua", "Shahrasti", "Sadar", "Matlabsouth", "Hajiganj", "Matlabnorth", "Faridgonj"}},
            
            // Chapainawabganj
            {"Chapainawabganj", new List<string>{"Chapainawabganjsadar", "Gomostapur", "Nachol", "Bholahat", "Shibganj"}},
            
            // Chattogram
            {"Chattogram", new List<string>{"Rangunia", "Sitakunda", "Mirsharai", "Patiya", "Sandwip", "Banshkhali", "Boalkhali", "Anwara", "Chandanaish", "Satkania", "Lohagara", "Hathazari", "Fatikchhari", "Raozan", "Karnafuli"}},
            
            // Chuadanga
            {"Chuadanga", new List<string>{"Chuadangasadar", "Alamdanga", "Damurhuda", "Jibannagar"}},
            {"Cumilla", new List<string>{"Debidwar", "Barura", "Brahmanpara", "Chandina", "Chauddagram", "Daudkandi", "Homna", "Laksam", "Muradnagar", "Nangalkot", "Cumillasadar", "Meghna", "Monohargonj", "Sadarsouth", "Titas", "Burichang", "Lalmai"}},
            {"Cox's Bazar", new List<string>{"Sadar", "Chakaria", "Kutubdia", "Ukhiya", "Moheshkhali", "Pekua", "Ramu", "Teknaf"}},
            {"Dhaka", new List<string>{"Savar", "Dhamrai", "Keraniganj", "Nawabganj", "Dohar"}},
            {"Dinajpur", new List<string>{"Nawabganj", "Birganj", "Ghoraghat", "Birampur", "Parbatipur", "Bochaganj", "Kaharol", "Fulbari", "Dinajpursadar", "Hakimpur", "Khansama", "Birol", "Chirirbandar"}},
            {"Faridpur", new List<string>{"Sadar", "Alfadanga", "Boalmari", "Sadarpur", "Nagarkanda", "Bhanga", "Charbhadrasan", "Madhukhali", "Saltha"}},
            {"Feni", new List<string>{"Chhagalnaiya", "Sadar", "Sonagazi", "Fulgazi", "Parshuram", "Daganbhuiyan"}},
            {"Gaibandha", new List<string>{"Sadullapur", "Gaibandhasadar", "Palashbari", "Saghata", "Gobindaganj", "Sundarganj", "Phulchari"}},
            {"Gazipur", new List<string>{"Kaliganj", "Kaliakair", "Kapasia", "Sadar", "Sreepur"}},
            {"Gopalganj", new List<string>{"Sadar", "Kashiani", "Tungipara", "Kotalipara", "Muksudpur"}},
            {"Habiganj", new List<string>{"Nabiganj", "Bahubal", "Ajmiriganj", "Baniachong", "Lakhai", "Chunarughat", "Habiganjsadar", "Madhabpur", "Shayestaganj"}},
            {"Jamalpur", new List<string>{"Jamalpursadar", "Melandah", "Islampur", "Dewangonj", "Sarishabari", "Madarganj", "Bokshiganj"}},
            {"Jashore", new List<string>{"Manirampur", "Abhaynagar", "Bagherpara", "Chougachha", "Jhikargacha", "Keshabpur", "Sadar", "Sharsha"}},
            {"Jhalokati", new List<string>{"Sadar", "Kathalia", "Nalchity", "Rajapur"}},
            {"Jhenaidah", new List<string>{"Sadar", "Shailkupa", "Harinakundu", "Kaliganj", "Kotchandpur", "Moheshpur"}},
            {"Joypurhat", new List<string>{"Akkelpur", "Kalai", "Khetlal", "Panchbibi", "Joypurhatsadar"}},
            {"Khagrachari", new List<string>{"Sadar", "Dighinala", "Panchari", "Laxmichhari", "Mohalchari", "Manikchari", "Ramgarh", "Matiranga", "Guimara"}},
            {"Khulna", new List<string>{"Paikgasa", "Fultola", "Digholia", "Rupsha", "Terokhada", "Dumuria", "Botiaghata", "Dakop", "Koyra"}},
            {"Kishoreganj", new List<string>{"Itna", "Katiadi", "Bhairab", "Tarail", "Hossainpur", "Pakundia", "Kuliarchar", "Kishoreganjsadar", "Karimgonj", "Bajitpur", "Austagram", "Mithamoin", "Nikli"}},
            {"Kurigram", new List<string>{"Kurigramsadar", "Nageshwari", "Bhurungamari", "Phulbari", "Rajarhat", "Ulipur", "Chilmari", "Rowmari", "Charrajibpur"}},
            {"Kushtia", new List<string>{"Kushtiasadar", "Kumarkhali", "Khoksa", "Mirpur", "Daulatpur", "Bheramara"}},
            {"Lakshmipur", new List<string>{"Sadar", "Kamalnagar", "Raipur", "Ramgati", "Ramganj"}},
            {"Lalmonirhat", new List<string>{"Sadar", "Kaliganj", "Hatibandha", "Patgram", "Aditmari"}},
            {"Madaripur", new List<string>{"Sadar", "Shibchar", "Kalkini", "Rajoir", "Dasar"}},
            {"Magura", new List<string>{"Shalikha", "Sreepur", "Magurasadar", "Mohammadpur"}},
            {"Manikganj", new List<string>{"Harirampur", "Saturia", "Sadar", "Gior", "Shibaloy", "Doulatpur", "Singiar"}},
            {"Meherpur", new List<string>{"Mujibnagar", "Meherpursadar", "Gangni"}},
            {"Moulvibazar", new List<string>{"Barlekha", "Kamolganj", "Kulaura", "Moulvibazarsadar", "Rajnagar", "Sreemangal", "Juri"}},
            {"Munshiganj", new List<string>{"Sadar", "Sreenagar", "Sirajdikhan", "Louhajanj", "Gajaria", "Tongibari"}},
            {"Mymensingh", new List<string>{"Fulbaria", "Trishal", "Bhaluka", "Muktagacha", "Mymensinghsadar", "Dhobaura", "Phulpur", "Haluaghat", "Gouripur", "Gafargaon", "Iswarganj", "Nandail", "Tarakanda"}},
            {"Naogaon", new List<string>{"Mohadevpur", "Badalgachi", "Patnitala", "Dhamoirhat", "Niamatpur", "Manda", "Atrai", "Raninagar", "Naogaonsadar", "Porsha", "Sapahar"}},
            {"Narail", new List<string>{"Narailsadar", "Lohagara", "Kalia"}},
            {"Narayanganj", new List<string>{"Araihazar", "Bandar", "Narayanganjsadar", "Rupganj", "Sonargaon"}},
            {"Narsingdi", new List<string>{"Belabo", "Monohardi", "Narsingdisadar", "Palash", "Raipura", "Shibpur"}},
            {"Natore", new List<string>{"Natoresadar", "Singra", "Baraigram", "Bagatipara", "Lalpur", "Gurudaspur", "Naldanga"}},
            {"Netrokona", new List<string>{"Barhatta", "Durgapur", "Kendua", "Atpara", "Madan", "Khaliajuri", "Kalmakanda", "Mohongonj", "Purbadhala", "Netrokonasadar"}},
            {"Nilphamari", new List<string>{"Syedpur", "Domar", "Dimla", "Jaldhaka", "Kishorganj", "Nilphamarisadar"}},
            {"Noakhali", new List<string>{"Sadar", "Companiganj", "Begumganj", "Hatia", "Subarnachar", "Kabirhat", "Senbug", "Chatkhil", "Sonaimuri"}},
            {"Pabna", new List<string> { "Sujanagar", "Ishurdi", "Bhangura", "Pabnasadar", "Bera", "Atghoria", "Chatmohar", "Santhia", "Faridpur" }},
            {"Panchagarh", new List<string> { "Panchagarhsadar", "Debiganj", "Boda", "Atwari", "Tetulia" }},
            {"Patuakhali", new List<string> { "Bauphal", "Sadar", "Dumki", "Dashmina", "Kalapara", "Mirzaganj", "Galachipa", "Rangabali" }},
            {"Pirojpur", new List<string> { "Sadar", "Nazirpur", "Kawkhali", "Bhandaria", "Mathbaria", "Nesarabad", "Indurkani" }},
            {"Rajbari", new List<string> { "Sadar", "Goalanda", "Pangsa", "Baliakandi", "Kalukhali" }},
            {"Rangamati", new List<string>{"Sadar", "Kaptai", "Kawkhali", "Baghaichari", "Barkal", "Langadu", "Rajasthali", "Belaichari", "Juraichari", "Naniarchar"}},
            {"Rangpur", new List<string> { "Rangpursadar", "Gangachara", "Taragonj", "Badargonj", "Mithapukur", "Pirgonj", "Kaunia", "Pirgacha" }},
            {"Satkhira", new List<string> { "Assasuni", "Debhata", "Kalaroa", "Satkhirasadar", "Shyamnagar", "Tala", "Kaliganj" }},
            {"Shariatpur", new List<string> { "Sadar", "Naria", "Zajira", "Gosairhat", "Bhedarganj", "Damudya" }},
            {"Sherpur", new List<string> { "Sherpursadar", "Nalitabari", "Sreebordi", "Nokla", "Jhenaigati" }},
            {"Sirajganj", new List<string> { "Belkuchi", "Chauhali", "Kamarkhand", "Kazipur", "Raigonj", "Shahjadpur", "Sirajganjsadar", "Tarash", "Ullapara" }},
            {"Sunamganj", new List<string> { "Sadar", "Southsunamganj", "Bishwambarpur", "Chhatak", "Jagannathpur", "Dowarabazar", "Tahirpur", "Dharmapasha", "Jamalganj", "Shalla", "Derai", "Madhyanagar" }},
            {"Sylhet", new List<string> { "Balaganj", "Beanibazar", "Bishwanath", "Companiganj", "Fenchuganj", "Golapganj", "Gowainghat", "Jaintiapur", "Kanaighat", "Sylhetsadar", "Zakiganj", "Dakshinsurma", "Osmaninagar" }},
            {"Tangail", new List<string> { "Basail", "Bhuapur", "Delduar", "Ghatail", "Gopalpur", "Madhupur", "Mirzapur", "Nagarpur", "Sakhipur", "Tangailsadar", "Kalihati", "Dhanbari" }},
            {"Thakurgaon", new List<string> { "Thakurgaonsadar", "Pirganj", "Ranisankail", "Haripur", "Baliadangi" }},
        };

        

        public static List<string> GetAllCities()
        {
            return addresses.Keys.ToList();
        }

        // Get upazilas by city
        public static List<string> GetUpazilas(string city)
        {
            if (addresses.ContainsKey(city))
                return addresses[city];
            return new List<string>();
        }
    }
}
