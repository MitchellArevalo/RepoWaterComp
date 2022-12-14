using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Editar_Cliente : Form
    {
        public Editar_Cliente()
        {
            InitializeComponent();
        }
        public static string id_buscado, doc, name, mail, predio, direcc, Estrato_p, rolUpdate, departamento, ciudad;

        private void txt_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static List<string> ciudadesList = new List<string> {
            "Pinillos-Bolívar",
            "Abejorral-Antioquia",
            "Abrego-Norte de Santander",
            "Abriaquí-Antioquia",
            "Acacias-Meta",
            "Acandí-Chocó",
            "Acevedo-Huila",
            "Achí-Bolívar",
            "Agrado-Huila",
            "AguaDeDios-Cundinamarca",
            "Aguachica-Cesar",
            "Aguada-Santander",
            "Aguadas-Caldas",
            "Aguazul-Casanare",
            "AgustínCodazzi-Cesar",
            "Aipe-Huila",
            "Albán-Cundinamarca",
            "Albán-Nariño",
            "Albania-Caquetá",
            "Albania-La Guajira",
            "Alcalá-Valle del Cauca",
            "Aldana-Nariño",
            "Alejandría-Antioquia",
            "Algarrobo-Magdalena",
            "Algeciras-Huila",
            "Almaguer-Cauca",
            "Almeida-Boyacá",
            "Alpujarra-Tolima",
            "Altamira-Huila",
            "AltoBaudo-Chocó",
            "Alvarado-Tolima",
            "Amagá-Antioquia",
            "Amalfi-Antioquia",
            "Ambalema-Tolima",
            "Anapoima-Cundinamarca",
            "Ancuyá-Nariño",
            "Andalucía-Valle del Cauca",
            "Andes-Antioquia",
            "Angelópolis-Antioquia",
            "Angostura-Antioquia",
            "Anolaima-Cundinamarca",
            "Anorí-Antioquia",
            "Anserma-Caldas",
            "Ansermanuevo-Valle del Cauca",
            "Anza-Antioquia",
            "Anzoátegui-Tolima",
            "Apartadó-Antioquia",
            "Apía-Risaralda",
            "Apulo-Cundinamarca",
            "Aquitania-Boyacá",
            "Aracataca-Magdalena",
            "Aranzazu-Caldas",
            "Aratoca-Santander",
            "Arauca-Arauca",
            "Arauquita-Arauca",
            "Arbeláez-Cundinamarca",
            "Arboleda-Nariño",
            "Arboledas-Norte de Santander",
            "Arboletes-Antioquia",
            "Arcabuco-Boyacá",
            "Arenal-Bolívar",
            "Argelia-Antioquia",
            "Argelia-Cauca",
            "Argelia-Valle del Cauca",
            "Ariguaní-Magdalena",
            "Arjona-Bolívar",
            "Armenia-Quindío",
            "Armenia-Antioquia",
            "Armero-Tolima",
            "Astrea-Cesar",
            "Ataco-Tolima",
            "Atrato-Chocó",
            "Ayapel-Córdoba",
            "BahíaSolano-Chocó",
            "BajoBaudó-Chocó",
            "Balboa-Cauca",
            "Balboa-Risaralda",
            "Baranoa-Atlántico",
            "Baraya-Huila",
            "Barbacoas-Nariño",
            "Barbosa-Antioquia",
            "Barbosa-Santander",
            "Barichara-Santander",
            "BarrancaDeUpía-Meta",
            "Barrancabermeja-Santander",
            "Barrancas-La Guajira",
            "BarrancoDeLoba-Bolívar",
            "Barranquilla-Atlántico",
            "Becerril-Cesar",
            "Belalcázar-Caldas",
            "Belén-Boyacá",
            "Belén-Nariño",
            "BelénDeLosAndaquies-Caquetá",
            "BelénDeUmbría-Risaralda",
            "Bello-Antioquia",
            "Belmira-Antioquia",
            "Berbeo-Boyacá",
            "Betania-Antioquia",
            "Betéitiva-Boyacá",
            "Betulia-Antioquia",
            "Bituima-Cundinamarca",
            "Boavita-Boyacá",
            "Bochalema-Norte de Santander",
            "Bogotá-Cundinamarca",
            "Bojacá-Cundinamarca",
            "Bojaya-Chocó",
            "Bolívar-Cauca",
            "Bolívar-Santander",
            "Bolívar-Valle del Cauca",
            "Bosconia-Cesar",
            "Boyacá-Boyacá",
            "Briceño-Antioquia",
            "Briceño-Boyacá",
            "Bucaramanga-Santander",
            "Bucarasica-Norte de Santander",
            "Buenaventura-Valle del Cauca",
            "Buenavista-Córdoba",
            "Buenavista-Boyacá",
            "Buenavista-Quindío",
            "BuenosAires-Cauca",
            "Buesaco-Nariño",
            "Bugalagrande-Valle del Cauca",
            "Buriticá-Antioquia",
            "Busbanzá-Boyacá",
            "Cabrera-Cundinamarca",
            "Cáceres-Antioquia",
            "Cachipay-Cundinamarca",
            "Cachirá-Norte de Santander",
            "Cácota-Norte de Santander",
            "Caicedo-Antioquia",
            "Caicedonia-Valle del Cauca",
            "Caimito-Sucre",
            "Cajamarca-Tolima",
            "Cajibío-Cauca",
            "Cajicá-Cundinamarca",
            "Calamar-Bolívar",
            "Calarca-Quindío",
            "Caldas-Antioquia",
            "Caldas-Boyacá",
            "Caldono-Cauca",
            "Cali-Valle del Cauca",
            "Calima-Valle del Cauca",
            "Caloto-Cauca",
            "Campamento-Antioquia",
            "CampoDeLaCruz-Atlántico",
            "Campoalegre-Huila",
            "Campohermoso-Boyacá",
            "Canalete-Córdoba",
            "Candelaria-Valle del Cauca",
            "Candelaria-Atlántico",
            "Cantagallo-Bolívar",
            "Cañasgordas-Antioquia",
            "Caparrapí-Cundinamarca",
            "Capitanejo-Santander",
            "Caqueza-Cundinamarca",
            "Caracolí-Antioquia",
            "Caramanta-Antioquia",
            "Carepa-Antioquia",
            "CarmenDeApicalá-Tolima",
            "CarmenDeCarupa-Cundinamarca",
            "Carolina-Antioquia",
            "Cartagena-Bolívar",
            "CartagenaDeIndias-Bolívar",
            "CartagenaDelChairá-Caquetá",
            "Cartago-Valle del Cauca",
            "Casabianca-Tolima",
            "CastillaLaNueva-Meta",
            "Caucasia-Antioquia",
            "Cereté-Córdoba",
            "Cerinza-Boyacá",
            "Cerrito-Santander",
            "CerroSanAntonio-Magdalena",
            "Cértegui-Chocó",
            "Chachagüí-Nariño",
            "Chaguaní-Cundinamarca",
            "Chaparral-Tolima",
            "Charalá-Santander",
            "Chía-Cundinamarca",
            "Chibolo-Magdalena",
            "Chigorodó-Antioquia",
            "Chimá-Córdoba",
            "Chimichagua-Cesar",
            "Chinácota-Norte de Santander",
            "Chinavita-Boyacá",
            "Chinchiná-Caldas",
            "Chinú-Córdoba",
            "Chipaque-Cundinamarca",
            "Chipatá-Santander",
            "Chiquinquirá-Boyacá",
            "Chíquiza-Boyacá",
            "Chiriguaná-Cesar",
            "Chiscas-Boyacá",
            "Chita-Boyacá",
            "Chitagá-Norte de Santander",
            "Chitaraque-Boyacá",
            "Chivatá-Boyacá",
            "Chivor-Boyacá",
            "Choachí-Cundinamarca",
            "Chocontá-Cundinamarca",
            "Cicuco-Bolívar",
            "Ciénaga-Magdalena",
            "CiénagaDeOro-Córdoba",
            "Ciénega-Boyacá",
            "Cimitarra-Santander",
            "Circasia-Quindío",
            "Cisneros-Antioquia",
            "CiudadBolivar-Antioquia",
            "Clemencia-Bolívar",
            "Cocorná-Antioquia",
            "Coello-Tolima",
            "Cogua-Cundinamarca",
            "Colombia-Huila",
            "Colón-Putumayo",
            "Colón-Nariño",
            "Cómbita-Boyacá",
            "Concepción-Antioquia",
            "Concepción-Santander",
            "Concordia-Antioquia",
            "Concordia-Magdalena",
            "Condoto-Chocó",
            "Consaca-Nariño",
            "Contadero-Nariño",
            "Contratación-Santander",
            "Convención-Norte de Santander",
            "Copacabana-Antioquia",
            "Coper-Boyacá",
            "Córdoba-Bolívar",
            "Córdoba-Nariño",
            "Córdoba-Quindío",
            "Corinto-Cauca",
            "Corozal-Sucre",
            "Corrales-Boyacá",
            "Cota-Cundinamarca",
            "Cotorra-Córdoba",
            "Covarachía-Boyacá",
            "Coveñas-Sucre",
            "Coyaima-Tolima",
            "CravoNorte-Arauca",
            "Cuaspud-Nariño",
            "Cubará-Boyacá",
            "Cubarral-Meta",
            "Cucaita-Boyacá",
            "Cucunubá-Cundinamarca",
            "Cúcuta-Norte de Santander",
            "Cucutilla-Norte de Santander",
            "Cuítiva-Boyacá",
            "Cumaral-Meta",
            "Cumaribo-Vichada",
            "Cumbal-Nariño",
            "Cumbitara-Nariño",
            "Cunday-Tolima",
            "Curillo-Caquetá",
            "Curití-Santander",
            "Curumaní-Cesar",
            "Dabeiba-Antioquia",
            "Dagua-Valle del Cauca",
            "Distracción-La Guajira",
            "Dolores-Tolima",
            "DonMatías-Antioquia",
            "Dosquebradas-Risaralda",
            "Duitama-Boyacá",
            "Durania-Norte de Santander",
            "Ebéjico-Antioquia",
            "ElÁguila-Valle del Cauca",
            "ElBagre-Antioquia",
            "ElBanco-Magdalena",
            "ElCairo-Valle del Cauca",
            "ElCarmen-Norte de Santander",
            "ElCarmenDeAtrato-Chocó",
            "ElCarmenDeBolívar-Bolívar",
            "ElCarmenDeChucurí-Santander",
            "ElCarmenDeViboral-Antioquia",
            "ElCerrito-Valle del Cauca",
            "ElCharco-Nariño",
            "ElCocuy-Boyacá",
            "ElColegio-Cundinamarca",
            "ElCopey-Cesar",
            "ElDoncello-Caquetá",
            "ElDovio-Valle del Cauca",
            "ElEspino-Boyacá",
            "ElGuamo-Bolívar",
            "ElMolino-La Guajira",
            "ElPaso-Cesar",
            "ElPaujil-Caquetá",
            "ElPeñol-Nariño",
            "ElPeñón-Cundinamarca",
            "ElPeñón-Santander",
            "ElPiñon-Magdalena",
            "ElPlayón-Santander",
            "ElRetén-Magdalena",
            "ElRosal-Cundinamarca",
            "ElRosario-Nariño",
            "ElSantuario-Antioquia",
            "ElTablónDeGómez-Nariño",
            "ElTambo-Cauca",
            "ElTambo-Nariño",
            "ElZulia-Norte de Santander",
            "Enciso-Santander",
            "Entrerrios-Antioquia",
            "Envigado-Antioquia",
            "Espinal-Tolima",
            "Facatativá-Cundinamarca",
            "Falan-Tolima",
            "Filadelfia-Caldas",
            "Filandia-Quindío",
            "Firavitoba-Boyacá",
            "Flandes-Tolima",
            "Florencia-Caquetá",
            "Florencia-Cauca",
            "Floresta-Boyacá",
            "Florián-Santander",
            "Florida-Valle del Cauca",
            "Floridablanca-Santander",
            "Fomeque-Cundinamarca",
            "Fonseca-La Guajira",
            "Fortul-Arauca",
            "Fosca-Cundinamarca",
            "Fredonia-Antioquia",
            "Fresno-Tolima",
            "Frontino-Antioquia",
            "FuenteDeOro-Meta",
            "Fundación-Magdalena",
            "Funes-Nariño",
            "Funza-Cundinamarca",
            "Fúquene-Cundinamarca",
            "Fusagasugá-Cundinamarca",
            "Gachala-Cundinamarca",
            "Gachancipá-Cundinamarca",
            "Gachantivá-Boyacá",
            "Gachetá-Cundinamarca",
            "Galán-Santander",
            "Galapa-Atlántico",
            "Galeras-Sucre",
            "Gama-Cundinamarca",
            "Gamarra-Cesar",
            "Gambita-Santander",
            "Gameza-Boyacá",
            "Garagoa-Boyacá",
            "Garzón-Huila",
            "Génova-Quindío",
            "Gigante-Huila",
            "Ginebra-Valle del Cauca",
            "Giraldo-Antioquia",
            "Girardot-Cundinamarca",
            "Girardota-Antioquia",
            "Girón-Santander",
            "GómezPlata-Antioquia",
            "González-Cesar",
            "Gramalote-Norte de Santander",
            "Granada-Meta",
            "Granada-Antioquia",
            "Granada-Cundinamarca",
            "Guaca-Santander",
            "Guacamayas-Boyacá",
            "Guacarí-Valle del Cauca",
            "Guachetá-Cundinamarca",
            "Guachucal-Nariño",
            "GuadalajaraDeBuga-Valle del Cauca",
            "Guadalupe-Huila",
            "Guadalupe-Antioquia",
            "Guadalupe-Santander",
            "Guaduas-Cundinamarca",
            "Guaitarilla-Nariño",
            "Gualmatán-Nariño",
            "Guamal-Meta",
            "Guamal-Magdalena",
            "Guamo-Tolima",
            "Guapi-Cauca",
            "Guaranda-Sucre",
            "Guarne-Antioquia",
            "Guasca-Cundinamarca",
            "Guatapé-Antioquia",
            "Guataquí-Cundinamarca",
            "Guatavita-Cundinamarca",
            "Guateque-Boyacá",
            "Guática-Risaralda",
            "Guavatá-Santander",
            "GuayabalDeSiquima-Cundinamarca",
            "Guayabetal-Cundinamarca",
            "Guayatá-Boyacá",
            "Güepsa-Santander",
            "Güicán-Boyacá",
            "Gutiérrez-Cundinamarca",
            "Hacarí-Norte de Santander",
            "HatilloDeLoba-Bolívar",
            "HatoCorozal-Casanare",
            "Hatonuevo-La Guajira",
            "Heliconia-Antioquia",
            "Herrán-Norte de Santander",
            "Herveo-Tolima",
            "Hispania-Antioquia",
            "Hobo-Huila",
            "Honda-Tolima",
            "Ibagué-Tolima",
            "Icononzo-Tolima",
            "Iles-Nariño",
            "Imués-Nariño",
            "Inírida-Guainía",
            "Inzá-Cauca",
            "Ipiales-Nariño",
            "Iquira-Huila",
            "Isnos-Huila",
            "Istmina-Chocó",
            "Itagüí-Antioquia",
            "Ituango-Antioquia",
            "Iza-Boyacá",
            "Jambaló-Cauca",
            "Jamundí-Valle del Cauca",
            "Jardín-Antioquia",
            "Jenesano-Boyacá",
            "Jericó-Antioquia",
            "Jericó-Boyacá",
            "Jerusalén-Cundinamarca",
            "JesúsMaría-Santander",
            "JuanDeAcosta-Atlántico",
            "Junín-Cundinamarca",
            "Juradó-Chocó",
            "LaApartada-Córdoba",
            "LaArgentina-Huila",
            "LaBelleza-Santander",
            "LaCalera-Cundinamarca",
            "LaCapilla-Boyacá",
            "LaCeja-Antioquia",
            "LaCelia-Risaralda",
            "LaCruz-Nariño",
            "LaCumbre-Valle del Cauca",
            "LaDorada-Caldas",
            "LaEsperanza-Norte de Santander",
            "LaEstrella-Antioquia",
            "LaFlorida-Nariño",
            "LaGloria-Cesar",
            "LaJaguaDeIbirico-Cesar",
            "LaJaguaDelPilar-La Guajira",
            "LaLlanada-Nariño",
            "LaMacarena-Meta",
            "LaMerced-Caldas",
            "LaMesa-Cundinamarca",
            "LaMontañita-Caquetá",
            "LaPalma-Cundinamarca",
            "LaPaz-Cesar",
            "LaPaz-Santander",
            "LaPeña-Cundinamarca",
            "LaPintada-Antioquia",
            "LaPlata-Huila",
            "LaPrimavera-Vichada",
            "LaSierra-Cauca",
            "LaTebaida-Quindío",
            "LaUnión-Antioquia",
            "LaUnión-Valle del Cauca",
            "LaUnión-Nariño",
            "LaUnión-Sucre",
            "LaUvita-Boyacá",
            "LaVega-Cundinamarca",
            "LaVega-Cauca",
            "LaVictoria-Valle del Cauca",
            "LaVictoria-Boyacá",
            "LaVirginia-Risaralda",
            "Labateca-Norte de Santander",
            "Labranzagrande-Boyacá",
            "Landázuri-Santander",
            "Lebríja-Santander",
            "Leguízamo-Putumayo",
            "Leiva-Nariño",
            "Lenguazaque-Cundinamarca",
            "Lérida-Tolima",
            "Leticia-Amazonas",
            "Líbano-Tolima",
            "Liborina-Antioquia",
            "Linares-Nariño",
            "Lloró-Chocó",
            "López-Cauca",
            "Lorica-Córdoba",
            "LosAndes-Nariño",
            "LosCórdobas-Córdoba",
            "LosPalmitos-Sucre",
            "LosPatios-Norte de Santander",
            "Lourdes-Norte de Santander",
            "Luruaco-Atlántico",
            "Macanal-Boyacá",
            "Maceo-Antioquia",
            "Macheta-Cundinamarca",
            "Madrid-Cundinamarca",
            "Magangué-Bolívar",
            "Mahates-Bolívar",
            "Maicao-La Guajira",
            "Majagual-Sucre",
            "Málaga-Santander",
            "Malambo-Atlántico",
            "Mallama-Nariño",
            "Manatí-Atlántico",
            "Manaure-La Guajira",
            "Manaure-Cesar",
            "Maní-Casanare",
            "Manizales-Caldas",
            "Manta-Cundinamarca",
            "Manzanares-Caldas",
            "Margarita-Bolívar",
            "MaríaLaBaja-Bolívar",
            "Marinilla-Antioquia",
            "Maripí-Boyacá",
            "Mariquita-Tolima",
            "Marmato-Caldas",
            "Marquetalia-Caldas",
            "Marsella-Risaralda",
            "Marulanda-Caldas",
            "Matanza-Santander",
            "Medellín-Antioquia",
            "Medina-Cundinamarca",
            "MedioSanJuan-Chocó",
            "Melgar-Tolima",
            "Mercaderes-Cauca",
            "Miraflores-Boyacá",
            "Miranda-Cauca",
            "Mistrató-Risaralda",
            "Mitú-Vaupés",
            "Mocoa-Putumayo",
            "Mogotes-Santander",
            "Molagavita-Santander",
            "Momil-Córdoba",
            "Mompós-Bolívar",
            "Mongua-Boyacá",
            "Monguí-Boyacá",
            "Moniquirá-Boyacá",
            "Montebello-Antioquia",
            "Montecristo-Bolívar",
            "Montelíbano-Córdoba",
            "Montenegro-Quindío",
            "Montería-Córdoba",
            "Monterrey-Casanare",
            "Moñitos-Córdoba",
            "Morales-Bolívar",
            "Morales-Cauca",
            "Morelia-Caquetá",
            "Morroa-Sucre",
            "Mosquera-Cundinamarca",
            "Motavita-Boyacá",
            "Murillo-Tolima",
            "Murindó-Antioquia",
            "Mutatá-Antioquia",
            "Mutiscua-Norte de Santander",
            "Muzo-Boyacá",
            "Nariño-Antioquia",
            "Nariño-Cundinamarca",
            "Nariño-Nariño",
            "Nátaga-Huila",
            "Natagaima-Tolima",
            "Nechí-Antioquia",
            "Necoclí-Antioquia",
            "Neira-Caldas",
            "Neiva-Huila",
            "Nemocón-Cundinamarca",
            "Nilo-Cundinamarca",
            "Nimaima-Cundinamarca",
            "Nobsa-Boyacá",
            "Nocaima-Cundinamarca",
            "Norcasia-Caldas",
            "Nóvita-Chocó",
            "NuevaGranada-Magdalena",
            "NuevoColón-Boyacá",
            "Nunchía-Casanare",
            "Nuquí-Chocó",
            "Obando-Valle del Cauca",
            "Ocaña-Norte de Santander",
            "Oiba-Santander",
            "Oicatá-Boyacá",
            "Olaya-Antioquia",
            "Onzaga-Santander",
            "Oporapa-Huila",
            "Orito-Putumayo",
            "Orocué-Casanare",
            "Ortega-Tolima",
            "Ospina-Nariño",
            "Otanche-Boyacá",
            "Ovejas-Sucre",
            "Pachavita-Boyacá",
            "Pacho-Cundinamarca",
            "Pácora-Caldas",
            "Padilla-Cauca",
            "Paez-Cauca",
            "Páez-Boyacá",
            "Paicol-Huila",
            "Pailitas-Cesar",
            "Paime-Cundinamarca",
            "Paipa-Boyacá",
            "Pajarito-Boyacá",
            "Palermo-Huila",
            "Palestina-Caldas",
            "Palestina-Huila",
            "PalmarDeVarela-Atlántico",
            "Palmira-Valle del Cauca",
            "Palocabildo-Tolima",
            "Pamplona-Norte de Santander",
            "Pamplonita-Norte de Santander",
            "Pandi-Cundinamarca",
            "Panqueba-Boyacá",
            "Páramo-Santander",
            "Paratebueno-Cundinamarca",
            "Pasca-Cundinamarca",
            "Pasto-Nariño",
            "Patía-Cauca",
            "Pauna-Boyacá",
            "PazDeAriporo-Casanare",
            "PazDeRío-Boyacá",
            "Pedraza-Magdalena",
            "Pelaya-Cesar",
            "Pensilvania-Caldas",
            "Peñol-Antioquia",
            "Peque-Antioquia",
            "Pereira-Risaralda",
            "Pesca-Boyacá",
            "Piedecuesta-Santander",
            "Piedras-Tolima",
            "Piendamó-Cauca",
            "Pijao-Quindío",
            "PijiñoDelCarmen-Magdalena",
            "Pinchote-Santander",
            "Piojó-Atlántico",
            "Pital-Huila",
            "Pitalito-Huila",
            "Pivijay-Magdalena",
            "Planadas-Tolima",
            "PlanetaRica-Córdoba",
            "Plato-Magdalena",
            "Policarpa-Nariño",
            "Polonuevo-Atlántico",
            "Ponedera-Atlántico",
            "Popayán-Cauca",
            "Pore-Casanare",
            "Potosí-Nariño",
            "Pradera-Valle del Cauca",
            "Prado-Tolima",
            "Providencia-Nariño",
            "PuebloBello-Cesar",
            "PuebloNuevo-Córdoba",
            "PuebloRico-Risaralda",
            "Pueblorrico-Antioquia",
            "Puebloviejo-Magdalena",
            "PuenteNacional-Santander",
            "Puerres-Nariño",
            "PuertoAsís-Putumayo",
            "PuertoBerrío-Antioquia",
            "PuertoBoyacá- Boyacá",
            "PuertoCaicedo-Putumayo",
            "PuertoCarreño-Vichada",
            "PuertoColombia-Atlántico",
            "PuertoConcordia-Meta",
            "PuertoEscondido-Córdoba",
            "PuertoGaitán-Meta",
            "PuertoGuzmán-Putumayo",
            "PuertoLibertador-Córdoba",
            "PuertoLleras-Meta",
            "PuertoLópez-Meta",
            "PuertoNare-Antioquia",
            "PuertoParra-Santander",
            "PuertoRico-Caquetá",
            "PuertoRico-Meta",
            "PuertoRondón-Arauca",
            "PuertoSalgar-Cundinamarca",
            "Puerto-Santander",
            "PuertoTejada-Cauca",
            "PuertoTriunfo-Antioquia",
            "PuertoWilches-Santander",
            "Pulí-Cundinamarca",
            "Pupiales-Nariño",
            "Puracé-Cauca",
            "Purificación-Tolima",
            "Purísima-Córdoba",
            "Quebradanegra-Cundinamarca",
            "Quetame-Cundinamarca",
            "Quibdó-Chocó",
            "Quimbaya-Quindío",
            "Quinchía-Risaralda",
            "Quípama-Boyacá",
            "Quipile-Cundinamarca",
            "Ragonvalia-Norte de Santander",
            "Ramiriquí-Boyacá",
            "Ráquira-Boyacá",
            "Regidor-Bolívar",
            "Remedios-Antioquia",
            "Remolino-Magdalena",
            "Repelón-Atlántico",
            "Restrepo-Meta",
            "Restrepo-Valle del Cauca",
            "Retiro-Antioquia",
            "Ricaurte-Cundinamarca",
            "Ricaurte-Nariño",
            "RíoDeOro-Cesar",
            "RíoViejo-Bolívar",
            "Rioblanco-Tolima",
            "Riofrío-Valle del Cauca",
            "Riohacha-La Guajira",
            "Rionegro-Antioquia",
            "Rionegro-Santander",
            "Riosucio-Caldas",
            "Riosucio-Chocó",
            "Risaralda-Caldas",
            "Rivera-Huila",
            "Roldanillo-Valle del Cauca",
            "Roncesvalles-Tolima",
            "Rondón-Boyacá",
            "Rosas-Cauca",
            "Rovira-Tolima",
            "SabanaDeTorres-Santander",
            "Sabanagrande-Atlántico",
            "Sabanalarga-Atlántico",
            "Sabanalarga-Antioquia",
            "Sabanalarga-Casanare",
            "SabanasDeSanAngel-Magdalena",
            "Sabaneta-Antioquia",
            "Saboyá-Boyacá",
            "Sáchica-Boyacá",
            "Sahagún-Córdoba",
            "Saladoblanco-Huila",
            "Salamina-Caldas",
            "Salamina-Magdalena",
            "Salazar-Norte de Santander",
            "Saldaña-Tolima",
            "Salento-Quindío",
            "Salgar-Antioquia",
            "Samacá-Boyacá",
            "Samaná-Caldas",
            "Samaniego-Nariño",
            "Sampués-Sucre",
            "SanAgustín-Huila",
            "SanAlberto-Cesar",
            "SanAndrés-San Andrés y Providencia",
            "SanAndrés-Santander",
            "SanAndrés-Antioquia",
            "SanAndrésSotavento-Córdoba",
            "SanAntero-Córdoba",
            "SanAntonio-Tolima",
            "SanAntonioDelTequendama-Cundinamarca",
            "SanBenito-Santander",
            "SanBenitoAbad-Sucre",
            "SanBernardo-Cundinamarca",
            "SanBernardo-Nariño",
            "SanBernardoDelViento-Córdoba",
            "SanCalixto-Norte de Santander",
            "SanCarlos-Antioquia",
            "SanCarlos-Córdoba",
            "SanCayetano-Norte de Santander",
            "SanDiego-Cesar",
            "SanEduardo-Boyacá",
            "SanEstanislao-Bolívar",
            "SanFernando-Bolívar",
            "SanFrancisco-Antioquia",
            "SanFrancisco-Cundinamarca",
            "SanFrancisco-Putumayo",
            "SanGil-Santander",
            "SanJacinto-Bolívar",
            "SanJerónimo-Antioquia",
            "SanJoaquín-Santander",
            "SanJosé-Caldas",
            "SanJoséDeLaMontaña-Antioquia",
            "SanJoséDeMiranda-Santander",
            "SanJoséDePare-Boyacá",
            "SanJoséDelFragua-Caquetá",
            "SanJoséDelGuaviare-Guaviare",
            "SanJoséDelPalmar-Chocó",
            "SanJuanDeArama-Meta",
            "SanJuanDeRíoSeco-Cundinamarca",
            "SanJuanDeUrabá-Antioquia",
            "SanJuanDelCesar-La Guajira",
            "SanJuanNepomuceno-Bolívar",
            "SanLorenzo-Nariño",
            "SanLuis-Antioquia",
            "SanLuis-Tolima",
            "SanLuisDeGaceno-Boyacá",
            "SanLuisDePalenque-Casanare",
            "SanMarcos-Sucre",
            "SanMartín-Meta",
            "SanMartín-Cesar",
            "SanMartínDeLoba-Bolívar",
            "SanMateo-Boyacá",
            "SanMiguelDeSema-Boyacá",
            "SanOnofre-Sucre",
            "SanPablo-Bolívar",
            "SanPablo-Nariño",
            "SanPabloDeBorbur-Boyacá",
            "SanPedro-Sucre",
            "SanPedro-Valle del Cauca",
            "SanPedro-Antioquia",
            "SanPedroDeCartago-Nariño",
            "SanPedroDeUraba-Antioquia",
            "SanPelayo-Córdoba",
            "SanRafael-Antioquia",
            "SanRoque-Antioquia",
            "SanSebastián-Cauca",
            "SanSebastiánDeBuenavista-Magdalena",
            "SanVicente-Antioquia",
            "SanVicenteDeChucurí-Santander",
            "SanVicenteDelCaguán-Caquetá",
            "SanZenón-Magdalena",
            "Sandoná-Nariño",
            "SantaAna-Magdalena",
            "SantaBárbara-Antioquia",
            "SantaBárbaraDePinto-Magdalena",
            "SantaCatalina-Bolívar",
            "SantaHelenaDelOpón-Santander",
            "SantaIsabel-Tolima",
            "SantaLucía-Atlántico",
            "SantaMaría-Boyacá",
            "SantaMaría-Huila",
            "SantaMarta-Magdalena",
            "SantaRosaDeCabal-Risaralda",
            "SantaRosaDeOsos-Antioquia",
            "SantaRosaDeViterbo-Boyacá",
            "SantaRosaDelSur-Bolívar",
            "SantaRosalía-Vichada",
            "SantaSofía-Boyacá",
            "Santacruz-Nariño",
            "SantaféDeAntioquia-Antioquia",
            "Santana-Boyacá",
            "SantanderDeQuilichao-Cauca",
            "Santiago-Norte de Santander",
            "Santiago-Putumayo",
            "SantiagoDeTolú-Sucre",
            "SantoDomingo-Antioquia",
            "SantoTomás-Atlántico",
            "Santuario-Risaralda",
            "Sapuyes-Nariño",
            "Saravena-Arauca",
            "Sardinata-Norte de Santander",
            "Sasaima-Cundinamarca",
            "Sativanorte-Boyacá",
            "Sativasur-Boyacá",
            "Segovia-Antioquia",
            "Sesquilé-Cundinamarca",
            "Sevilla-Valle del Cauca",
            "Siachoque-Boyacá",
            "Sibaté-Cundinamarca",
            "Sibundoy-Putumayo",
            "Silos-Norte de Santander",
            "Silvania-Cundinamarca",
            "Silvia-Cauca",
            "Simacota-Santander",
            "Simijaca-Cundinamarca",
            "Simití-Bolívar",
            "Sincé-Sucre",
            "Sincelejo-Sucre",
            "Sipí-Chocó",
            "Sitionuevo-Magdalena",
            "Soacha-Cundinamarca",
            "Soatá-Boyacá",
            "Socha-Boyacá",
            "Socorro-Santander",
            "Socotá-Boyacá",
            "Sogamoso-Boyacá",
            "Soledad-Atlántico",
            "Solita-Caquetá",
            "Somondoco-Boyacá",
            "Sonson-Antioquia",
            "Sopetrán-Antioquia",
            "Soplaviento-Bolívar",
            "Sopó-Cundinamarca",
            "Sora-Boyacá",
            "Soracá-Boyacá",
            "Sotaquirá-Boyacá",
            "Sotara-Cauca",
            "Suaita-Santander",
            "Suan-Atlántico",
            "Suárez-Cauca",
            "Suárez-Tolima",
            "Suaza-Huila",
            "Subachoque-Cundinamarca",
            "Sucre-Santander",
            "Sucre-Sucre",
            "Suesca-Cundinamarca",
            "Supatá-Cundinamarca",
            "Supía-Caldas",
            "Susa-Cundinamarca",
            "Susacón-Boyacá",
            "Sutamarchán-Boyacá",
            "Sutatausa-Cundinamarca",
            "Sutatenza-Boyacá",
            "Tabio-Cundinamarca",
            "Tadó-Chocó",
            "TalaiguaNuevo-Bolívar",
            "Tamalameque-Cesar",
            "Tame-Arauca",
            "Támesis-Antioquia",
            "Taminango-Nariño",
            "Tangua-Nariño",
            "Tarazá-Antioquia",
            "Tarqui-Huila",
            "Tarso-Antioquia",
            "Tasco-Boyacá",
            "Tauramena-Casanare",
            "Tausa-Cundinamarca",
            "Tello-Huila",
            "Tena-Cundinamarca",
            "Tenerife-Magdalena",
            "Tenjo-Cundinamarca",
            "Tenza-Boyacá",
            "Teorama-Norte de Santander",
            "Teruel-Huila",
            "Tesalia-Huila",
            "Tibacuy-Cundinamarca",
            "Tibaná-Boyacá",
            "Tibasosa-Boyacá",
            "Tibirita-Cundinamarca",
            "Tibú-Norte de Santander",
            "Tierralta-Córdoba",
            "Timaná-Huila",
            "Timbío-Cauca",
            "Timbiquí-Cauca",
            "Tinjacá-Boyacá",
            "Tipacoque-Boyacá",
            "Tiquisio-Bolívar",
            "Titiribí-Antioquia",
            "Toca-Boyacá",
            "Tocaima-Cundinamarca",
            "Tocancipá-Cundinamarca",
            "Togüí-Boyacá",
            "Toledo-Antioquia",
            "Toledo-Norte de Santander",
            "TolúViejo-Sucre",
            "Tópaga-Boyacá",
            "Topaipí-Cundinamarca",
            "Toribio-Cauca",
            "Toro-Valle del Cauca",
            "Tota-Boyacá",
            "Totoró-Cauca",
            "Trinidad-Casanare",
            "Trujillo-Valle del Cauca",
            "Tubará-Atlántico",
            "Tuluá-Valle del Cauca",
            "Tumaco-Nariño",
            "Tunja-Boyacá",
            "Tununguá-Boyacá",
            "Túquerres-Nariño",
            "Turbaco-Bolívar",
            "Turbaná-Bolívar",
            "Turbo-Antioquia",
            "Turmequé-Boyacá",
            "Tuta-Boyacá",
            "Tutazá-Boyacá",
            "Ubalá-Cundinamarca",
            "Ubaque-Cundinamarca",
            "Ulloa-Valle del Cauca",
            "Umbita-Boyacá",
            "Une-Cundinamarca",
            "Unguía-Chocó",
            "UniónPanamericana-Chocó",
            "Uramita-Antioquia",
            "Uribe-Meta",
            "Uribia-La Guajira",
            "Urrao-Antioquia",
            "Urumita-La Guajira",
            "Usiacurí-Atlántico",
            "Útica-Cundinamarca",
            "Valdivia-Antioquia",
            "Valencia-Córdoba",
            "ValleDeSanJosé-Santander",
            "ValleDeSanJuan-Tolima",
            "ValleDelGuamuez-Putumayo",
            "Valledupar-Cesar",
            "Valparaíso-Antioquia",
            "Valparaíso-Caquetá",
            "Vegachí-Antioquia",
            "Vélez-Santander",
            "Venadillo-Tolima",
            "Venecia-Antioquia",
            "Venecia-Cundinamarca",
            "Ventaquemada-Boyacá",
            "Vergara-Cundinamarca",
            "Versalles-Valle del Cauca",
            "Vianí-Cundinamarca",
            "Victoria-Caldas",
            "Vijes-Valle del Cauca",
            "VillaCaro-Norte de Santander",
            "VillaDeLeyva-Boyacá",
            "VillaDeSanDiegoDeUbate-Cundinamarca",
            "VillaDelRosario-Norte de Santander",
            "VillaRica-Cauca",
            "Villagarzón-Putumayo",
            "Villagómez-Cundinamarca",
            "Villahermosa-Tolima",
            "Villamaría-Caldas",
            "Villanueva-Bolívar",
            "Villanueva-Casanare",
            "Villanueva-La Guajira",
            "Villanueva-Santander",
            "Villapinzón-Cundinamarca",
            "Villarrica-Tolima",
            "Villavicencio-Meta",
            "Villavieja-Huila",
            "Villeta-Cundinamarca",
            "Viotá-Cundinamarca",
            "Viracachá-Boyacá",
            "Vistahermosa-Meta",
            "Viterbo-Caldas",
            "Yacopí-Cundinamarca",
            "Yacuanquer-Nariño",
            "Yaguará-Huila",
            "Yalí-Antioquia",
            "Yarumal-Antioquia",
            "Yolombó-Antioquia",
            "Yondó-Antioquia",
            "Yopal-Casanare",
            "Yotoco-Valle del Cauca",
            "Yumbo-Valle del Cauca",
            "Zambrano-Bolívar",
            "Zapatoca-Santander",
            "Zaragoza-Antioquia",
            "Zarzal-Valle del Cauca",
            "Zetaquira-Boyacá",
            "Zipacón-Cundinamarca",
            "Zipaquirá-Cundinamarca",
            "ZonaBananera-Magdalena"
        };

        public static bool activo = false;
        public static void llenarCamposEditables(string id, string nombre, string Documento_identidad, string Estrato, string CodP, string Direccion, string correo, string active, string depto, string city)
        { //llenarCamposEditables(id,nombre,Documento_identidad,Estrato, CodP, Direccion,correo,active);
            id_buscado = id;
            doc = Documento_identidad;
            name = nombre;
            mail = correo;
            Estrato_p = Estrato;
            predio = CodP;
            direcc = Direccion;
            if (active == "True")
            {
                activo = true;
            }
            else
            {
                activo = false;
            }
            departamento = depto;
            ciudad = city;

        }
        private void Editar_Cliente_Load(object sender, EventArgs e)
        {
            this.txt_documento.Text = doc;
            this.txt_nombre.Text = name;
            this.txtx_codpredio.Text = predio;
            this.txt_email.Text = mail;
            this.txt_direccion.Text = direcc;
            this.estratobox.Text = Estrato_p;
            this.ActiveCheckbox.Checked = activo;
            this.DepartamentoBox.Text = departamento;
            this.ciudadBox.Text = ciudad;

        }

        private void DepartamentoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> ciudadesPorDepto = new List<string>();
            for (int i = 0; i < ciudadesList.Count; i++)
            {

                string[] arreglo = ciudadesList[i].Split(new[] { '-' }, 2);

                if (arreglo[1] == DepartamentoBox.Text)
                {
                    ciudadesPorDepto.Add(arreglo[0].ToString());
                }

            }
            this.ciudadBox.DataSource = ciudadesPorDepto;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            try
            {
                bool validado = true;
                DatosBD validaciones = new DatosBD();
                if (txt_documento.Text != doc)
                {
                    validado = validaciones.validarDocCliente(txt_documento.Text);
                }
                if (txtx_codpredio.Text != predio)
                {
                    validado = validaciones.validarPredio(txtx_codpredio.Text);
                }
                if (txt_email.Text != mail)
                {
                    validado = validaciones.validarClientEmail(txt_email.Text);
                }
                if (txt_direccion.Text != direcc)
                {
                    validado = validaciones.validarClientAdress(txt_direccion.Text);
                }
                if (validado == false)
                {
                    return;
                }
                int ID = int.Parse(id_buscado);
                if (txt_documento.Text == string.Empty || txt_nombre.Text == string.Empty || estratobox.Text.Length == 0 || txt_email.Text == string.Empty || txt_direccion.Text == string.Empty || txtx_codpredio.Text == string.Empty)
                {
                    MessageBox.Show("Todos los campos deben estar llenos");
                    return;
                }

                string activeclient;

                if (ActiveCheckbox.Checked == true)
                {
                    activeclient = "True";
                }
                else
                {
                    activeclient = "False";
                }
                if (DatosBD.ComprobarFormatoEmail(txt_email.Text) == false)
                {
                    MessageBox.Show("El correo electrónico no existe");
                    txt_email.Text = "Dirección no valida";
                    txt_email.ForeColor = Color.Red;
                    return;
                }

                try
                {
                    if (DatosBD.UpdateClientes(ID, txt_nombre.Text, txt_documento.Text, estratobox.Text, txtx_codpredio.Text, txt_direccion.Text, txt_email.Text, activeclient) == false)
                    {
                        MessageBox.Show("Hubo un error al intentar actualizar el usuario");
                        return;
                    }
                    MessageBox.Show("Usuario actualizado");
                    this.Close();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error al intentar actualizar el usuario " + ex);
                }



            }
            catch (SqlException ex1)
            {

                MessageBox.Show("Error Generated. Details: " + ex1.ToString());
            }
        }
    }
}
