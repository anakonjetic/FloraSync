using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FloraSync.Migrations
{
    /// <inheritdoc />
    public partial class FiftySeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Temperature", "Type" },
                values: new object[] { "Huge road behind draw goal large commercial thank wish wall.", "/images/monstera_deliciosa.png", 3, 4, 3 });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[,]
                {
                    { 2, "Soldier discussion however without himself can home establish up possible.", "/images/aloe_vera.png", 0, "Aloe Vera", 3, 7, 3 },
                    { 3, "Cold identify growth especially threat catch charge meet hour product security television.", "/images/boston_fern.png", 1, "Boston Fern", 2, 7, 4 },
                    { 4, "Affect him exactly toward media rock your fill civil development suggest wrong treat.", "/images/snake_plant.png", 4, "Snake Plant", 4, 3, 3 },
                    { 5, "Enter politics feeling way special when.", "/images/peace_lily.png", 4, "Peace Lily", 0, 1, 3 },
                    { 6, "Bag movie describe red half behind daughter present born likely morning.", "/images/spider_plant.png", 1, "Spider Plant", 1, 1, 1 },
                    { 7, "Then exist state toward western guess writer road.", "/images/jade_plant.png", 2, "Jade Plant", 2, 5, 4 },
                    { 8, "Sure become of believe result table born effort member early worker woman.", "/images/english_ivy.png", 2, "English Ivy", 1, 7, 0 },
                    { 9, "Hold tough identify take report anything agent concern machine structure up around people.", "/images/zz_plant.png", 2, "ZZ Plant", 1, 2, 0 },
                    { 10, "Mention scene everyone feeling finally effect stuff.", "/images/areca_palm.png", 4, "Areca Palm", 4, 3, 4 },
                    { 11, "Skin large network wait official help or society four there rule.", "/images/chinese_evergreen.png", 0, "Chinese Evergreen", 3, 5, 1 },
                    { 12, "Detail see media information high about language.", "/images/cast_iron_plant.png", 3, "Cast Iron Plant", 4, 1, 3 },
                    { 13, "Least year professor other sort relate cell range discuss week east pick.", "/images/bamboo_palm.png", 0, "Bamboo Palm", 2, 6, 0 },
                    { 14, "Suffer across do international head ready PM about red.", "/images/philodendron.png", 4, "Philodendron", 3, 6, 4 },
                    { 15, "Ready ability avoid great black around bag.", "/images/calathea.png", 4, "Calathea", 2, 3, 0 },
                    { 16, "Concern check little mention economic support which know.", "/images/croton.png", 2, "Croton", 1, 5, 1 },
                    { 17, "Matter thought exist production story PM.", "/images/rubber_plant.png", 0, "Rubber Plant", 4, 4, 0 },
                    { 18, "Several in structure activity voice two.", "/images/pothos.png", 0, "Pothos", 3, 5, 4 },
                    { 19, "Carry short conference physical because give protect.", "/images/fiddle_leaf_fig.png", 3, "Fiddle Leaf Fig", 0, 3, 4 },
                    { 20, "Everybody factor opportunity look time experience develop skin by dream source either address.", "/images/dracaena.png", 1, "Dracaena", 3, 0, 0 },
                    { 21, "My skill fire sell probably look fly mind.", "/images/dieffenbachia.png", 2, "Dieffenbachia", 1, 6, 0 },
                    { 22, "Glass street anyone save almost everyone feel.", "/images/bird_of_paradise.png", 3, "Bird of Paradise", 1, 5, 4 },
                    { 23, "Moment unit can really book hotel defense occur husband.", "/images/kalanchoe.png", 1, "Kalanchoe", 0, 7, 4 },
                    { 24, "Majority organization west south Mrs now process student once at rich center.", "/images/aglaonema.png", 2, "Aglaonema", 1, 2, 3 },
                    { 25, "As wonder theory able nearly true remain goal recent.", "/images/oxalis.png", 0, "Oxalis", 2, 6, 0 },
                    { 26, "Soon check my fall story instead rather fear.", "/images/begonia.png", 0, "Begonia", 0, 4, 2 },
                    { 27, "Development son affect order serious quickly.", "/images/peperomia.png", 0, "Peperomia", 4, 1, 0 },
                    { 28, "Speak always successful whatever money should able.", "/images/fittonia.png", 1, "Fittonia", 1, 2, 4 },
                    { 29, "School she finish Democrat leader know manage between unit else authority.", "/images/norfolk_island_pine.png", 3, "Norfolk Island Pine", 4, 1, 4 },
                    { 30, "Three officer necessary score stand effect decision go short its eye.", "/images/hoya.png", 4, "Hoya", 3, 5, 2 },
                    { 31, "Address everyone community collection answer still current choose simply hour among class artist.", "/images/staghorn_fern.png", 4, "Staghorn Fern", 2, 2, 2 },
                    { 32, "Pay social least agent goal room pressure century indicate this teacher.", "/images/african_violet.png", 4, "African Violet", 2, 2, 3 },
                    { 33, "A right during realize watch door risk debate.", "/images/anthurium.png", 2, "Anthurium", 3, 6, 4 },
                    { 34, "Capital forward home mean person alone although story score vote evening room.", "/images/maidenhair_fern.png", 0, "Maidenhair Fern", 0, 4, 4 },
                    { 35, "Parent become attention example service herself some social baby west according.", "/images/cordyline.png", 0, "Cordyline", 0, 0, 0 },
                    { 36, "Bank training heavy price here day sell.", "/images/polka_dot_plant.png", 3, "Polka Dot Plant", 2, 4, 2 },
                    { 37, "Trade east agreement none since weight major than high.", "/images/schefflera.png", 2, "Schefflera", 3, 6, 1 },
                    { 38, "Could bad low land plant newspaper west discover parent might report federal increase.", "/images/tradescantia.png", 0, "Tradescantia", 2, 0, 1 },
                    { 39, "Leave stay fact stock city citizen get beat become drop discover safe movement.", "/images/tamarind.png", 4, "Tamarind", 3, 4, 0 },
                    { 40, "Machine wind up different myself ask air toward.", "/images/chili_pepper.png", 4, "Chili Pepper", 2, 0, 3 },
                    { 41, "Of list test in civil Mr behind western responsibility like point.", "/images/rosemary.png", 3, "Rosemary", 4, 5, 1 },
                    { 42, "Unit bed whatever also reveal responsibility drop raise anything every administration.", "/images/lavender.png", 3, "Lavender", 4, 7, 4 },
                    { 43, "Over wait south low individual day.", "/images/thyme.png", 3, "Thyme", 0, 6, 3 },
                    { 44, "Project source feeling exactly difficult focus wait specific hour candidate.", "/images/mint.png", 3, "Mint", 0, 7, 3 },
                    { 45, "Next man them plan power six defense believe.", "/images/basil.png", 3, "Basil", 0, 0, 1 },
                    { 46, "Whose beyond staff wait push hospital.", "/images/parsley.png", 2, "Parsley", 2, 4, 2 },
                    { 47, "Tonight act moment since answer her.", "/images/chamomile.png", 1, "Chamomile", 2, 3, 1 },
                    { 48, "Author red attention receive authority article member life that point buy.", "/images/lemon_balm.png", 4, "Lemon Balm", 4, 2, 1 },
                    { 49, "Voice break anything sign direction them relate.", "/images/eucalyptus.png", 2, "Eucalyptus", 4, 3, 1 },
                    { 50, "Room feel environmental case worker too how responsibility.", "/images/dill.png", 2, "Dill", 1, 5, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Temperature", "Type" },
                values: new object[] { "Monstera leaves develop holes to withstand tropical storms.", "/images/monstera.png", 1, 2, 0 });
        }
    }
}
