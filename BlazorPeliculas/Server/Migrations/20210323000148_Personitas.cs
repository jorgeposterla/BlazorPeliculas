using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorPeliculas.Server.Migrations
{
    public partial class Personitas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 10, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 10" },
                    { 343, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 343" },
                    { 342, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 342" },
                    { 341, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 341" },
                    { 340, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 340" },
                    { 339, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 339" },
                    { 338, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 338" },
                    { 337, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 337" },
                    { 336, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 336" },
                    { 335, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 335" },
                    { 334, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 334" },
                    { 333, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 333" },
                    { 332, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 332" },
                    { 344, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 344" },
                    { 331, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 331" },
                    { 329, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 329" },
                    { 328, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 328" },
                    { 327, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 327" },
                    { 326, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 326" },
                    { 325, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 325" },
                    { 324, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 324" },
                    { 323, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 323" },
                    { 322, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 322" },
                    { 321, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 321" },
                    { 320, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 320" },
                    { 319, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 319" },
                    { 318, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 318" },
                    { 330, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 330" },
                    { 345, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 345" },
                    { 346, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 346" },
                    { 347, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 347" },
                    { 374, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 374" },
                    { 373, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 373" },
                    { 372, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 372" },
                    { 371, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 371" },
                    { 370, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 370" },
                    { 369, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 369" },
                    { 368, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 368" },
                    { 367, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 367" },
                    { 366, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 366" },
                    { 365, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 365" },
                    { 364, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 364" }
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 363, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 363" },
                    { 362, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 362" },
                    { 361, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 361" },
                    { 360, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 360" },
                    { 359, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 359" },
                    { 358, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 358" },
                    { 357, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 357" },
                    { 356, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 356" },
                    { 355, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 355" },
                    { 354, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 354" },
                    { 353, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 353" },
                    { 352, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 352" },
                    { 351, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 351" },
                    { 350, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 350" },
                    { 349, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 349" },
                    { 348, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 348" },
                    { 317, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 317" },
                    { 375, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 375" },
                    { 316, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 316" },
                    { 314, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 314" },
                    { 282, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 282" },
                    { 281, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 281" },
                    { 280, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 280" },
                    { 279, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 279" },
                    { 278, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 278" },
                    { 277, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 277" },
                    { 276, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 276" },
                    { 275, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 275" },
                    { 274, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 274" },
                    { 273, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 273" },
                    { 272, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 272" },
                    { 271, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 271" },
                    { 283, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 283" },
                    { 270, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 270" },
                    { 268, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 268" },
                    { 267, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 267" },
                    { 266, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 266" },
                    { 265, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 265" },
                    { 264, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 264" },
                    { 263, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 263" },
                    { 262, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 262" },
                    { 261, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 261" }
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 260, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 260" },
                    { 259, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 259" },
                    { 258, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 258" },
                    { 257, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 257" },
                    { 269, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 269" },
                    { 284, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 284" },
                    { 285, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 285" },
                    { 286, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 286" },
                    { 313, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 313" },
                    { 312, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 312" },
                    { 311, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 311" },
                    { 310, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 310" },
                    { 309, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 309" },
                    { 308, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 308" },
                    { 307, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 307" },
                    { 306, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 306" },
                    { 305, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 305" },
                    { 304, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 304" },
                    { 303, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 303" },
                    { 302, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 302" },
                    { 301, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 301" },
                    { 300, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 300" },
                    { 299, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 299" },
                    { 298, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 298" },
                    { 297, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 297" },
                    { 296, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 296" },
                    { 295, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 295" },
                    { 294, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 294" },
                    { 293, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 293" },
                    { 292, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 292" },
                    { 291, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 291" },
                    { 290, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 290" },
                    { 289, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 289" },
                    { 288, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 288" },
                    { 287, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 287" },
                    { 315, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 315" },
                    { 376, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 376" },
                    { 377, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 377" },
                    { 378, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 378" },
                    { 466, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 466" },
                    { 465, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 465" },
                    { 464, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 464" }
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 463, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 463" },
                    { 462, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 462" },
                    { 461, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 461" },
                    { 460, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 460" },
                    { 459, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 459" },
                    { 458, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 458" },
                    { 457, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 457" },
                    { 456, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 456" },
                    { 455, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 455" },
                    { 467, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 467" },
                    { 454, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 454" },
                    { 452, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 452" },
                    { 451, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 451" },
                    { 450, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 450" },
                    { 449, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 449" },
                    { 448, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 448" },
                    { 447, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 447" },
                    { 446, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 446" },
                    { 445, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 445" },
                    { 444, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 444" },
                    { 443, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 443" },
                    { 442, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 442" },
                    { 441, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 441" },
                    { 453, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 453" },
                    { 468, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 468" },
                    { 469, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 469" },
                    { 470, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 470" },
                    { 497, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 497" },
                    { 496, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 496" },
                    { 495, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 495" },
                    { 494, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 494" },
                    { 493, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 493" },
                    { 492, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 492" },
                    { 491, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 491" },
                    { 490, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 490" },
                    { 489, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 489" },
                    { 488, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 488" },
                    { 487, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 487" },
                    { 486, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 486" },
                    { 485, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 485" },
                    { 484, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 484" },
                    { 483, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 483" }
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 482, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 482" },
                    { 481, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 481" },
                    { 480, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 480" },
                    { 479, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 479" },
                    { 478, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 478" },
                    { 477, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 477" },
                    { 476, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 476" },
                    { 475, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 475" },
                    { 474, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 474" },
                    { 473, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 473" },
                    { 472, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 472" },
                    { 471, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 471" },
                    { 440, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 440" },
                    { 439, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 439" },
                    { 438, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 438" },
                    { 437, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 437" },
                    { 405, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 405" },
                    { 404, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 404" },
                    { 403, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 403" },
                    { 402, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 402" },
                    { 401, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 401" },
                    { 400, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 400" },
                    { 399, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 399" },
                    { 398, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 398" },
                    { 397, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 397" },
                    { 396, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 396" },
                    { 395, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 395" },
                    { 394, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 394" },
                    { 393, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 393" },
                    { 392, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 392" },
                    { 391, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 391" },
                    { 390, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 390" },
                    { 389, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 389" },
                    { 388, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 388" },
                    { 387, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 387" },
                    { 386, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 386" },
                    { 385, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 385" },
                    { 384, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 384" },
                    { 383, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 383" },
                    { 382, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 382" },
                    { 381, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 381" },
                    { 380, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 380" }
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 379, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 379" },
                    { 406, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 406" },
                    { 256, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 256" },
                    { 407, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 407" },
                    { 409, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 409" },
                    { 436, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 436" },
                    { 435, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 435" },
                    { 434, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 434" },
                    { 433, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 433" },
                    { 432, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 432" },
                    { 431, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 431" },
                    { 430, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 430" },
                    { 429, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 429" },
                    { 428, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 428" },
                    { 427, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 427" },
                    { 426, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 426" },
                    { 425, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 425" },
                    { 424, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 424" },
                    { 423, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 423" },
                    { 422, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 422" },
                    { 421, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 421" },
                    { 420, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 420" },
                    { 419, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 419" },
                    { 418, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 418" },
                    { 417, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 417" },
                    { 416, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 416" },
                    { 415, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 415" },
                    { 414, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 414" },
                    { 413, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 413" },
                    { 412, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 412" },
                    { 411, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 411" },
                    { 410, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 410" },
                    { 408, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 408" },
                    { 255, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 255" },
                    { 254, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 254" },
                    { 253, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 253" },
                    { 98, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 98" },
                    { 97, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 97" },
                    { 96, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 96" },
                    { 95, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 95" },
                    { 94, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 94" },
                    { 93, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 93" }
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 92, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 92" },
                    { 91, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 91" },
                    { 90, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 90" },
                    { 89, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 89" },
                    { 88, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 88" },
                    { 87, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 87" },
                    { 99, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 99" },
                    { 86, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 86" },
                    { 84, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 84" },
                    { 83, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 83" },
                    { 82, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 82" },
                    { 81, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 81" },
                    { 80, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 80" },
                    { 79, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 79" },
                    { 78, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 78" },
                    { 77, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 77" },
                    { 76, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 76" },
                    { 75, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 75" },
                    { 74, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 74" },
                    { 73, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 73" },
                    { 85, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 85" },
                    { 100, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 100" },
                    { 101, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 101" },
                    { 102, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 102" },
                    { 129, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 129" },
                    { 128, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 128" },
                    { 127, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 127" },
                    { 126, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 126" },
                    { 125, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 125" },
                    { 124, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 124" },
                    { 123, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 123" },
                    { 122, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 122" },
                    { 121, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 121" },
                    { 120, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 120" },
                    { 119, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 119" },
                    { 118, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 118" },
                    { 117, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 117" },
                    { 116, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 116" },
                    { 115, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 115" },
                    { 114, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 114" },
                    { 113, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 113" },
                    { 112, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 112" }
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 111, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 111" },
                    { 110, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 110" },
                    { 109, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 109" },
                    { 108, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 108" },
                    { 107, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 107" },
                    { 106, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 106" },
                    { 105, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 105" },
                    { 104, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 104" },
                    { 103, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 103" },
                    { 72, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 72" },
                    { 71, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 71" },
                    { 70, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 70" },
                    { 69, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 69" },
                    { 37, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 37" },
                    { 36, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 36" },
                    { 35, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 35" },
                    { 34, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 34" },
                    { 33, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 33" },
                    { 32, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 32" },
                    { 31, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 31" },
                    { 30, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 30" },
                    { 29, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 29" },
                    { 28, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 28" },
                    { 27, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 27" },
                    { 26, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 26" },
                    { 25, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 25" },
                    { 24, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 24" },
                    { 23, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 23" },
                    { 22, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 22" },
                    { 21, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 21" },
                    { 20, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 20" },
                    { 19, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 19" },
                    { 18, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 18" },
                    { 17, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 17" },
                    { 16, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 16" },
                    { 15, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 15" },
                    { 14, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 14" },
                    { 13, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 13" },
                    { 12, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 12" },
                    { 11, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 11" },
                    { 38, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 38" },
                    { 130, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 130" }
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 39, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 39" },
                    { 41, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 41" },
                    { 68, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 68" },
                    { 67, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 67" },
                    { 66, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 66" },
                    { 65, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 65" },
                    { 64, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 64" },
                    { 63, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 63" },
                    { 62, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 62" },
                    { 61, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 61" },
                    { 60, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 60" },
                    { 59, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 59" },
                    { 58, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 58" },
                    { 57, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 57" },
                    { 56, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 56" },
                    { 55, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 55" },
                    { 54, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 54" },
                    { 53, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 53" },
                    { 52, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 52" },
                    { 51, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 51" },
                    { 50, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 50" },
                    { 49, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 49" },
                    { 48, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 48" },
                    { 47, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 47" },
                    { 46, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 46" },
                    { 45, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 45" },
                    { 44, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 44" },
                    { 43, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 43" },
                    { 42, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 42" },
                    { 40, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 40" },
                    { 498, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 498" },
                    { 131, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 131" },
                    { 133, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 133" },
                    { 221, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 221" },
                    { 220, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 220" },
                    { 219, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 219" },
                    { 218, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 218" },
                    { 217, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 217" },
                    { 216, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 216" },
                    { 215, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 215" },
                    { 214, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 214" },
                    { 213, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 213" }
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 212, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 212" },
                    { 211, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 211" },
                    { 210, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 210" },
                    { 222, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 222" },
                    { 209, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 209" },
                    { 207, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 207" },
                    { 206, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 206" },
                    { 205, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 205" },
                    { 204, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 204" },
                    { 203, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 203" },
                    { 202, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 202" },
                    { 201, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 201" },
                    { 200, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 200" },
                    { 199, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 199" },
                    { 198, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 198" },
                    { 197, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 197" },
                    { 196, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 196" },
                    { 208, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 208" },
                    { 223, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 223" },
                    { 224, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 224" },
                    { 225, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 225" },
                    { 252, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 252" },
                    { 251, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 251" },
                    { 250, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 250" },
                    { 249, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 249" },
                    { 248, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 248" },
                    { 247, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 247" },
                    { 246, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 246" },
                    { 245, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 245" },
                    { 244, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 244" },
                    { 243, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 243" },
                    { 242, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 242" },
                    { 241, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 241" },
                    { 240, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 240" },
                    { 239, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 239" },
                    { 238, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 238" },
                    { 237, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 237" },
                    { 236, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 236" },
                    { 235, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 235" },
                    { 234, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 234" },
                    { 233, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 233" },
                    { 232, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 232" }
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 231, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 231" },
                    { 230, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 230" },
                    { 229, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 229" },
                    { 228, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 228" },
                    { 227, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 227" },
                    { 226, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 226" },
                    { 195, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 195" },
                    { 194, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 194" },
                    { 193, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 193" },
                    { 192, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 192" },
                    { 160, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 160" },
                    { 159, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 159" },
                    { 158, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 158" },
                    { 157, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 157" },
                    { 156, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 156" },
                    { 155, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 155" },
                    { 154, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 154" },
                    { 153, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 153" },
                    { 152, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 152" },
                    { 151, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 151" },
                    { 150, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 150" },
                    { 149, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 149" },
                    { 148, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 148" },
                    { 147, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 147" },
                    { 146, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 146" },
                    { 145, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 145" },
                    { 144, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 144" },
                    { 143, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 143" },
                    { 142, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 142" },
                    { 141, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 141" },
                    { 140, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 140" },
                    { 139, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 139" },
                    { 138, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 138" },
                    { 137, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 137" },
                    { 136, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 136" },
                    { 135, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 135" },
                    { 134, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 134" },
                    { 161, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 161" },
                    { 132, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 132" },
                    { 162, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 162" },
                    { 164, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 164" },
                    { 191, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 191" }
                });

            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Biografia", "FechaNacimiento", "Foto", "Nombre" },
                values: new object[,]
                {
                    { 190, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 190" },
                    { 189, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 189" },
                    { 188, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 188" },
                    { 187, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 187" },
                    { 186, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 186" },
                    { 185, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 185" },
                    { 184, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 184" },
                    { 183, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 183" },
                    { 182, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 182" },
                    { 181, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 181" },
                    { 180, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 180" },
                    { 179, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 179" },
                    { 178, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 178" },
                    { 177, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 177" },
                    { 176, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 176" },
                    { 175, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 175" },
                    { 174, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 174" },
                    { 173, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 173" },
                    { 172, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 172" },
                    { 171, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 171" },
                    { 170, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 170" },
                    { 169, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 169" },
                    { 168, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 168" },
                    { 167, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 167" },
                    { 166, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 166" },
                    { 165, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 165" },
                    { 163, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 163" },
                    { 499, null, new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), null, "Persona 499" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Personas",
                keyColumn: "Id",
                keyValue: 499);
        }
    }
}
