/*
	Creado por
	Fecha creacion
	Descrcipcion
*/
CREATE TABLE [dbo].[Empresa](
	[ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[cNombreEmpresa] [nchar](10) NULL
) ON [PRIMARY]

GO


CREATE TABLE [dbo].[Pagos](
	[cID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[cDetalle] [varchar](500) NULL,
	[cTipo] [varchar](30) NULL,
	[cEmpresaPago] [varchar](50) NULL,
	[cEmpresaBeneficiaria] [varchar](50) NULL,
	[cPeriodoPago] [varchar](50) NULL,
	[cFechaPago] [date] NULL,
	[cEstutusPago] [int] NULL,
	[cPersonaPago] [varchar](50) NULL
) ON [PRIMARY]

GO


