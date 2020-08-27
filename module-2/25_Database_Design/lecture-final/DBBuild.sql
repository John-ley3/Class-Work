USE master;
go

-- Delete any previous ArtGallery DB
DROP DATABASE IF EXISTS ArtGallery;

CREATE DATABASE ArtGallery;
Go

Use ArtGallery;
go

-- Let's us a transaction
BEGIN Transaction;

CREATE TABLE Customers
(
	customerId	int	identity(1,1),
	first_name	nvarchar(20)	not null,
	last_name	nvarchar(50)	null,
	address_id	int	null,
	phone	varchar(15)	null,
	createdDate	datetime	not null

	constraint pk_customers primary key(customerId),
)

CREATE TABLE Artists
(
	artistId	int	identity(1,1),
	first_name	nvarchar(20)	not null,
	last_name	nvarchar(20)	null,

	constraint pk_artists primary key(artistId)
)

CREATE TABLE Art
(
	artId	int	identity(1,1),
	title	nvarchar(35)	not null,
	artistId	int	not null,

	constraint pk_art	primary key(artId),
)

CREATE TABLE Purchase
(
	customerId	int not null,
	artId	int not null,
	purchaseDate	datetime	not null,
	price	money	not null,

	constraint pk_customer_purchase primary key(customerId,artId)
)

CREATE TABLE Address
(
	addressId	int		identity(1,1),
	address1	varchar(20)	not null,
	address2	varchar(20)	null,
	city	varchar(100)	not null,
	state	char(2)	not null,
	zip	varchar(15)	not null,
	constraint pk_address primary key(addressId)
)

-- Let's add our foreign keys
ALTER TABLE Customers ADD constraint fk_customer_address foreign key(address_id) references Address(addressId)
ALTER TABLE Purchase ADD constraint fk_art_artist foreign key (artId) references art (artId)
ALTER TABLE Customers ADD constraint created DEFAULT GETDATE() FOR createdDate
ALTER TABLE Purchase ADD constraint today DEFAULT GETDATE() FOR purchaseDate
Commit

