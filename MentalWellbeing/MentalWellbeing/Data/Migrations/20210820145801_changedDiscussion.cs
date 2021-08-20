using Microsoft.EntityFrameworkCore.Migrations;

namespace MentalWellbeing.Data.Migrations
{
    public partial class changedDiscussion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Discussions_DiscussionId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Experts_ExpertId",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_ExpertId",
                table: "Comments",
                newName: "IX_Comments_ExpertId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_DiscussionId",
                table: "Comments",
                newName: "IX_Comments_DiscussionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Discussions_DiscussionId",
                table: "Comments",
                column: "DiscussionId",
                principalTable: "Discussions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Experts_ExpertId",
                table: "Comments",
                column: "ExpertId",
                principalTable: "Experts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Discussions_DiscussionId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Experts_ExpertId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ExpertId",
                table: "Comment",
                newName: "IX_Comment_ExpertId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_DiscussionId",
                table: "Comment",
                newName: "IX_Comment_DiscussionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Discussions_DiscussionId",
                table: "Comment",
                column: "DiscussionId",
                principalTable: "Discussions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Experts_ExpertId",
                table: "Comment",
                column: "ExpertId",
                principalTable: "Experts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
