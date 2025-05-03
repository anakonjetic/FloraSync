using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FloraSync.Migrations
{
    /// <inheritdoc />
    public partial class FiftySeeds2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FunFact", "Light", "Temperature", "Type" },
                values: new object[] { "Monstera leaves develop holes to withstand heavy rainfall.", 1, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FunFact", "Light", "Temperature", "Type", "Water" },
                values: new object[] { "Aloe vera gel can be used to treat sunburns.", 1, 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FunFact", "Type", "Water" },
                values: new object[] { "Ferns were around before dinosaurs roamed the earth.", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Water" },
                values: new object[] { "Its fruit is edible and often used in jams and drinks.", "/images/prickly_pear.png", 1, "Prickly Pear", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FunFact", "Light", "Temperature", "Type", "Water" },
                values: new object[] { "It can bloom even in low light.", 1, 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FunFact", "ImageUrl", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Pothos can grow in water without soil.", "/images/pothos.png", "Pothos", 2, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type", "Water" },
                values: new object[] { "Basil is considered a sacred herb in some cultures.", "/images/basil.png", 1, "Basil", 6, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Water" },
                values: new object[] { "Air plants don't need soil to grow.", "/images/tillandsia.png", 1, "Tillandsia", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Fiddle Leaf Figs can grow over 10 feet indoors.", "/images/fiddle_leaf_fig.png", 1, "Fiddle Leaf Fig", 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Jade is considered a symbol of good luck.", "/images/jade_plant.png", 1, "Jade Plant", 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Its fronds resemble a stag’s antlers.", "/images/staghorn_fern.png", 1, "Staghorn Fern", 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "It stores water to survive long droughts.", "/images/barrel_cactus.png", 1, "Barrel Cactus", 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type", "Water" },
                values: new object[] { "Known for its heart-shaped waxy flowers.", "/images/anthurium.png", 1, "Anthurium", 4, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Each pearl stores water.", "/images/string_of_pearls.png", 1, "String of Pearls", 2, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type", "Water" },
                values: new object[] { "Mint can spread quickly and become invasive.", "/images/mint.png", 1, "Mint", 6, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "It gets nutrients from the air.", "/images/spanish_moss.png", 1, "Spanish Moss", 2, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FunFact", "Light", "Temperature", "Type", "Water" },
                values: new object[] { "It can grow up to 100 feet in the wild.", 1, 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "It looks like a tiny zebra-striped aloe.", "/images/zebra_haworthia.png", 1, "Zebra Haworthia", 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Its leaves resemble soft hair.", "/images/maidenhair_fern.png", 1, "Maidenhair Fern", 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FunFact", "ImageUrl", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "It can live for over 30 years.", "/images/golden_barrel.png", "Golden Barrel", 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Orchids have the smallest seeds in the world.", "/images/orchid.png", 1, "Orchid", 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Water" },
                values: new object[] { "It can climb and cover entire walls.", "/images/english_ivy.png", 1, "English Ivy", 2, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FunFact", "ImageUrl", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Cilantro leaves and coriander seeds come from the same plant.", "/images/cilantro.png", "Cilantro", 2, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "It curls its leaves to retain water.", "/images/bulbosa.png", 1, "Bulbosa", 2, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type", "Water" },
                values: new object[] { "Leaves close up at night.", "/images/calathea.png", 1, "Calathea", 0, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type" },
                values: new object[] { "Named after a Mexican botanical illustrator.", "/images/echeveria.png", 1, "Echeveria", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "New fronds grow from the center like a bird’s nest.", "/images/bird’s_nest_fern.png", 1, "Bird’s Nest Fern", 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "FunFact", "ImageUrl", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Named for its pad-like shape.", "/images/bunny_ear_cactus.png", "Bunny Ear Cactus", 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "There are over 1,000 species.", "/images/begonia.png", 1, "Begonia", 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature" },
                values: new object[] { "It spreads easily and fast.", "/images/creeping_jenny.png", 1, "Creeping Jenny", 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type" },
                values: new object[] { "Used historically as a memory aid.", "/images/rosemary.png", 1, "Rosemary", 6 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type", "Water" },
                values: new object[] { "Its twisted leaves resemble Medusa’s hair.", "/images/caput_medusae.png", 1, "Caput Medusae", 7, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Can grow without direct sunlight.", "/images/philodendron.png", 1, "Philodendron", 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Fuzzy leaves resemble panda fur.", "/images/panda_plant.png", 1, "Panda Plant", 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Not a true fern!", "/images/asparagus_fern.png", 1, "Asparagus Fern", 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type" },
                values: new object[] { "Blooms in winter.", "/images/christmas_cactus.png", 1, "Christmas Cactus", 3 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Leaves are sensitive to cold water.", "/images/african_violet.png", 1, "African Violet", 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type", "Water" },
                values: new object[] { "Heart-shaped leaves on vines.", "/images/string_of_hearts.png", 1, "String of Hearts", 5, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Flowers are edible and tasty.", "/images/chives.png", 1, "Chives", 2, 6, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type", "Water" },
                values: new object[] { "Turns red when about to bloom.", "/images/ionantha.png", 1, "Ionantha", 7, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Also called dumb cane.", "/images/dieffenbachia.png", 1, "Dieffenbachia", 2, 0, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Offsets look like chicks.", "/images/hens_and_chicks.png", 1, "Hens and Chicks", 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Native to Australia.", "/images/kangaroo_fern.png", 1, "Kangaroo Fern", 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Covered in white hairs.", "/images/old_man_cactus.png", 1, "Old Man Cactus", 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Blooms in many vibrant colors.", "/images/petunia.png", 1, "Petunia", 2, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type" },
                values: new object[] { "Produces baby spiderettes.", "/images/spider_plant.png", 1, "Spider Plant", 5 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "FunFact", "ImageUrl", "Name", "Type", "Water" },
                values: new object[] { "Used for culinary and medicinal purposes.", "/images/thyme.png", "Thyme", 6, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "One of the easiest air plants.", "/images/stricta.png", 1, "Stricta", 2, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Technically a giant herb, not a tree.", "/images/banana_plant.png", 1, "Banana Plant", 2, 0, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FunFact", "Light", "Temperature", "Type" },
                values: new object[] { "Huge road behind draw goal large commercial thank wish wall.", 3, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FunFact", "Light", "Temperature", "Type", "Water" },
                values: new object[] { "Soldier discussion however without himself can home establish up possible.", 0, 3, 7, 3 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FunFact", "Type", "Water" },
                values: new object[] { "Cold identify growth especially threat catch charge meet hour product security television.", 7, 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Water" },
                values: new object[] { "Affect him exactly toward media rock your fill civil development suggest wrong treat.", "/images/snake_plant.png", 4, "Snake Plant", 4, 3 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FunFact", "Light", "Temperature", "Type", "Water" },
                values: new object[] { "Enter politics feeling way special when.", 4, 0, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FunFact", "ImageUrl", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Bag movie describe red half behind daughter present born likely morning.", "/images/spider_plant.png", "Spider Plant", 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type", "Water" },
                values: new object[] { "Then exist state toward western guess writer road.", "/images/jade_plant.png", 2, "Jade Plant", 5, 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Water" },
                values: new object[] { "Sure become of believe result table born effort member early worker woman.", "/images/english_ivy.png", 2, "English Ivy", 1, 0 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Hold tough identify take report anything agent concern machine structure up around people.", "/images/zz_plant.png", 2, "ZZ Plant", 1, 2, 0 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Mention scene everyone feeling finally effect stuff.", "/images/areca_palm.png", 4, "Areca Palm", 4, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Skin large network wait official help or society four there rule.", "/images/chinese_evergreen.png", 0, "Chinese Evergreen", 3, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Detail see media information high about language.", "/images/cast_iron_plant.png", 3, "Cast Iron Plant", 4, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type", "Water" },
                values: new object[] { "Least year professor other sort relate cell range discuss week east pick.", "/images/bamboo_palm.png", 0, "Bamboo Palm", 6, 0 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Suffer across do international head ready PM about red.", "/images/philodendron.png", 4, "Philodendron", 3, 6, 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type", "Water" },
                values: new object[] { "Ready ability avoid great black around bag.", "/images/calathea.png", 4, "Calathea", 3, 0 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Concern check little mention economic support which know.", "/images/croton.png", 2, "Croton", 1, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FunFact", "Light", "Temperature", "Type", "Water" },
                values: new object[] { "Matter thought exist production story PM.", 0, 4, 4, 0 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Several in structure activity voice two.", "/images/pothos.png", 0, "Pothos", 3, 5, 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Carry short conference physical because give protect.", "/images/fiddle_leaf_fig.png", 3, "Fiddle Leaf Fig", 0, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FunFact", "ImageUrl", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Everybody factor opportunity look time experience develop skin by dream source either address.", "/images/dracaena.png", "Dracaena", 3, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "My skill fire sell probably look fly mind.", "/images/dieffenbachia.png", 2, "Dieffenbachia", 1, 6, 0 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Water" },
                values: new object[] { "Glass street anyone save almost everyone feel.", "/images/bird_of_paradise.png", 3, "Bird of Paradise", 1, 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FunFact", "ImageUrl", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Moment unit can really book hotel defense occur husband.", "/images/kalanchoe.png", "Kalanchoe", 0, 7, 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Majority organization west south Mrs now process student once at rich center.", "/images/aglaonema.png", 2, "Aglaonema", 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type", "Water" },
                values: new object[] { "As wonder theory able nearly true remain goal recent.", "/images/oxalis.png", 0, "Oxalis", 6, 0 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type" },
                values: new object[] { "Soon check my fall story instead rather fear.", "/images/begonia.png", 0, "Begonia", 0, 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Development son affect order serious quickly.", "/images/peperomia.png", 0, "Peperomia", 4, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "FunFact", "ImageUrl", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Speak always successful whatever money should able.", "/images/fittonia.png", "Fittonia", 1, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "School she finish Democrat leader know manage between unit else authority.", "/images/norfolk_island_pine.png", 3, "Norfolk Island Pine", 4, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature" },
                values: new object[] { "Three officer necessary score stand effect decision go short its eye.", "/images/hoya.png", 4, "Hoya", 3 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type" },
                values: new object[] { "Address everyone community collection answer still current choose simply hour among class artist.", "/images/staghorn_fern.png", 4, "Staghorn Fern", 2 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type", "Water" },
                values: new object[] { "Pay social least agent goal room pressure century indicate this teacher.", "/images/african_violet.png", 4, "African Violet", 2, 3 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "A right during realize watch door risk debate.", "/images/anthurium.png", 2, "Anthurium", 3, 6, 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Capital forward home mean person alone although story score vote evening room.", "/images/maidenhair_fern.png", 0, "Maidenhair Fern", 0, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Parent become attention example service herself some social baby west according.", "/images/cordyline.png", 0, "Cordyline", 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type" },
                values: new object[] { "Bank training heavy price here day sell.", "/images/polka_dot_plant.png", 3, "Polka Dot Plant", 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Trade east agreement none since weight major than high.", "/images/schefflera.png", 2, "Schefflera", 3, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type", "Water" },
                values: new object[] { "Could bad low land plant newspaper west discover parent might report federal increase.", "/images/tradescantia.png", 0, "Tradescantia", 0, 1 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Leave stay fact stock city citizen get beat become drop discover safe movement.", "/images/tamarind.png", 4, "Tamarind", 3, 4, 0 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type", "Water" },
                values: new object[] { "Machine wind up different myself ask air toward.", "/images/chili_pepper.png", 4, "Chili Pepper", 0, 3 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Of list test in civil Mr behind western responsibility like point.", "/images/rosemary.png", 3, "Rosemary", 4, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Unit bed whatever also reveal responsibility drop raise anything every administration.", "/images/lavender.png", 3, "Lavender", 4, 7, 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Over wait south low individual day.", "/images/thyme.png", 3, "Thyme", 0, 6, 3 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Project source feeling exactly difficult focus wait specific hour candidate.", "/images/mint.png", 3, "Mint", 0, 7, 3 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Next man them plan power six defense believe.", "/images/basil.png", 3, "Basil", 0, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Type" },
                values: new object[] { "Whose beyond staff wait push hospital.", "/images/parsley.png", 2, "Parsley", 4 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "FunFact", "ImageUrl", "Name", "Type", "Water" },
                values: new object[] { "Tonight act moment since answer her.", "/images/chamomile.png", "Chamomile", 3, 1 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Author red attention receive authority article member life that point buy.", "/images/lemon_balm.png", 4, "Lemon Balm", 4, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { "Voice break anything sign direction them relate.", "/images/eucalyptus.png", 2, "Eucalyptus", 4, 3, 1 });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "FunFact", "ImageUrl", "Light", "Name", "Temperature", "Type", "Water" },
                values: new object[] { 50, "Room feel environmental case worker too how responsibility.", "/images/dill.png", 2, "Dill", 1, 5, 2 });
        }
    }
}
