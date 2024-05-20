drop table "Users";

create table "Users"
(
    "Id"          uuid      not null,
    "CreatedDate" timestamp not null,
    "Name"        text,
    "Surname"     text,
    "Email"       text,
    "BirthDate"   timestamp not null,
    "MobilePhone" text,
    "ApiKey"      uuid      not null,
    "IsActive"    boolean   not null,
    "AccountId"   uuid      not null
        constraint "FK_Users_Accounts_AccountId"
            references "Accounts"
            on delete cascade,
    "Unit"        text,
    "Column2"     text,
    "Column3"     text,
    "Column4"     text,
    "Column5"     text,
    "Column6"     text,
    "Column7"     text,
    "Column8"     text,
    "Column9"     text,
    "Column10"    text,
    "Column11"    text,
    "Column12"    text,
    "Column13"    text,
    "Column14"    text,
    "Column15"    text,
    "Column16"    text,
    "Column17"    text,
    "Column18"    text,
    "Column19"    text,
    "Column20"    text,
    "Column21"    text,
    "Column22"    text,
    "Column23"    text,
    "Column24"    text,
    "Column25"    text,
    "Column26"    text,
    "Column27"    text,
    "Column28"    text,
    "Column29"    text,
    "Column30"    text,
    "Column31"    text,
    "Column32"    text,
    "Column33"    text,
    "Column34"    text,
    "Column35"    text,
    "Column36"    text,
    "UpdatedDate" timestamp not null,
    "IsDeleted"   boolean   not null,
    constraint "PK_Users"
        primary key ("Id", "CreatedDate")
) partition by range ("CreatedDate");

alter table "Users" owner to test;

create index "IX_Users_AccountId"
    on "Users" ("AccountId");