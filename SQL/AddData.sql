ALTER TABLE dbo.Product DROP COLUMN Describe;
ALTER TABLE dbo.Product ADD Describe NVARCHAR(1000);
CREATE TABLE dbo.OderDetail
(
	OrderID NVARCHAR(50),
	ProductID NVARCHAR(50),
	AmountPro INT,
	Total INT
)

-------------------INSERT PRODUCT----------------------------
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)

VALUES
(   N'STN_T001', -- ProductID - nvarchar(50)
    N'Không chỉ là phù thuỷ', -- NameBook - nvarchar(50)
    N'1', -- WriterID - nvarchar(50)
    N'1', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Một câu chuyện dễ thương hài hước , chuyến phiêu lưu thú vị của cô phù thủy nhỏ Heckie , rồng thần thân thiện và cậu bạn thân Daniel.', -- Describe - nvarchar(100)
    N'STN_T001.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    )
GO


INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_T002', -- ProductID - nvarchar(50)
    N'Ngôi sao Kazan', -- NameBook - nvarchar(50)
    N'1', -- WriterID - nvarchar(50)
    N'1', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Bối cảnh ở ngôi nhà thờ cũ tại Vienna. Nội dung của truyện về cô bé Annika được kế thừa kho báu của dì nên sau đó cô bé phải đối mặt với những trắc trở, khó khăn sau này. Tôi muốn vẽ một bầu trời đầy sao rộng lớn như những ước muốn tự do và những băn khoăn thắc mắc khó giải đáp của cô bé Annika. Cô bé luôn muốn tìm kiếm sự thật và tìm về bên cạnh những người thân yêu của mình!', -- Describe - nvarchar(100)
    N'STN_T002.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
GO

INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_T003', -- ProductID - nvarchar(50)
    N'Quê ngoại', -- NameBook - nvarchar(50)
    N'3', -- WriterID - nvarchar(50)
    N'3', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Tác phẩm viết về một cô bé sống với ông bà ngoại ở quê từ nhỏ, bất ngờ một ngày cô bé phải chia xa vùng đất thân thương này. Những niềm nhớ, niềm thương của một đứa trẻ được tác giả thể hiện hết sức chân thật. Qua câu chuyện bạn đọc sẽ thấy được ước mong của tác giả muốn khắc vào tâm khảm của những đứa trẻ là tình yêu quê hương, vì dù có chia tay làng quê, dù có đi đâu xa, thì vẫn sẽ còn sự thương nhớ khôn nguôi. Cũng là một món quà tác giả dành tặng cho những con người đã trưởng thành và đang sống xa xứ sở của mình.', -- Describe - nvarchar(100)
    N'STN_T003.jpg', -- ImageID - nvarchar(50)
    N''  -- CategoryID - nvarchar(50)
    );

INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_T004', -- ProductID - nvarchar(50)
    N'Chú lợn biết bay', -- NameBook - nvarchar(50)
    N'2', -- WriterID - nvarchar(50)
    N'2', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Đọc tựa đề, nhiều độc giả thắc mắc tại sao chú lợn lại biết bay? Nhưng cũng chính tựa cuốn sách đã nói lên được nội dung và những điều mà tác giả muốn truyền tải đến cho bạn đọc. Đó là câu chuyện kể về một chú lợn có tên là Ụ Đất. Chú được sinh ra khác biệt với loài, khi có một túm lông nhỏ trông như đôi cánh ở trên lưng.', -- Describe - nvarchar(100)
    N'STN_T004.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_T005', -- ProductID - nvarchar(50)
    N'Phép lạ', -- NameBook - nvarchar(50)
    N'4', -- WriterID - nvarchar(50)
    N'4', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Truyện vừa Phép lạ kể về chuyến nghỉ hè của một cô bé thành phố yếu ớt bị bệnh tim bẩm sinh, từ nhỏ vốn luôn phải nép mình trong những quy tắc nghiêm ngặt về môi trường sống, hạn chế tiếp xúc với bên ngoài ồn ào phức tạp.', -- Describe - nvarchar(100)
    N'STN_T005.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_T006', -- ProductID - nvarchar(50)
    N'Hành trình đến sóng biển', -- NameBook - nvarchar(50)
    N'1', -- WriterID - nvarchar(50)
    N'1', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Truyện kể về hành trình trên đại dương lớn của cô bé, thuộc một bộ tộc trên đảo nhỏ xa bờ, đi tìm những điều thú vị của biển cả và trong cuộc sống. Lời kể của câu chuyện sống động hơn thông qua góc nhìn mộng mơ của một cô bé.', -- Describe - nvarchar(100)
    N'STN_T006.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_T007', -- ProductID - nvarchar(50)
    N'Tôi còn cách người trưởng thành rất xa', -- NameBook - nvarchar(50)
    N'5', -- WriterID - nvarchar(50)
    N'5', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Tuổi Thanh Xuân như một chiếc đồng hồ tràn đầy sức sống, nó tươi mới và ngọt ngào với hoa và lá, nó mang một vẻ đẹp của sự vô tư , hồn nhiên, hi vọng dù phải trải qua nhiều đau thương , gãy đổ, và quan trọng hơn hết tuổi Thanh Xuân cần thấy được vẻ đẹp của chính nó để nó tự biết quý trọng bản thân mà không hoài lãng phí.', -- Describe - nvarchar(100)
    N'STN_T007.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_T008', -- ProductID - nvarchar(50)
    N'Ai từng là con nít', -- NameBook - nvarchar(50)
    N'6', -- WriterID - nvarchar(50)
    N'3', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Đó là những món ăn dân dã, từng là “đặc sản” của một nhóm con nít nào đó, gắn với kỉ niệm ở một làng quê, một xóm phố nào đó. Đến bây giờ món ăn ấy vẫn đang “lưu hành” hoặc đã “tuyệt chủng” từ năm nẳm nào rồi, nhưng chắc chắn một điều: nó ngon lắm, ngon vô cùng tận bởi được ăn vào hồi ấy, theo cái kiểu ấy, của những đứa con nít ấy… Chỉ những ai từng là con nít mới cảm hết cái ngon như thế!', -- Describe - nvarchar(100)
    N'STN_T008.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_T009', -- ProductID - nvarchar(50)
    N'Con ma da sau vườn', -- NameBook - nvarchar(50)
    N'6', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Đó là sợ ma - nỗi sợ khá phổ biến với các em nhỏ, trong truyện ngắn Con Ma Da Sau Vườn. Hay nỗi sợ ít gặp, là phải làm bài tập làm văn... giống y như sách văn mẫu của một cô bé. Vượt qua nỗi sợ hãi, cô bé ấy quyết định không làm theo sách văn mẫu mà viết một bài văn trung thực, để làm một người trung thực.', -- Describe - nvarchar(100)
    N'STN_T009.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_T010', -- ProductID - nvarchar(50)
    N'Cuộc giải cứu hồn ma', -- NameBook - nvarchar(50)
    N'1', -- WriterID - nvarchar(50)
    N'1', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Câu chuyện rất hài hước và ngộ nghĩnh, những nhân vật rất đa dạng, dáng vẻ kỳ lạ, xuất thân kỳ lạ (gợi không ít sự hiếu kỳ) nhưng đáng yêu và gây không ngớt tiếng cười.', -- Describe - nvarchar(100)
    N'STN_T010.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_T011', -- ProductID - nvarchar(50)
    N'Bạn tôi là người ngoài hành tinh', -- NameBook - nvarchar(50)
    N'7', -- WriterID - nvarchar(50)
    N'7', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'câu chuyện khám phá một thế giới thật khác với bao điều kỳ lạ của hai cô bé Manju và Yoko. Hành trình tìm tòi bắt đầu khi lớp học của hai bạn nhỏ xuất hiện học sinh mới và cậu bé đó tự nhận mình là người ngoài hành tinh. Với cuốn sách này, trẻ em sẽ được kích thích sự tò mò, tìm hiểu thế giới xung quanh và phát triển trí tưởng tượng của bản thân.', -- Describe - nvarchar(100)
    N'STN_T011.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_T012', -- ProductID - nvarchar(50)
    N'Hồ chuồn chuồn', -- NameBook - nvarchar(50)
    N'1', -- WriterID - nvarchar(50)
    N'5', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Câu chuyện kể về tình bạn thân thời thơ ấu của hai đứa trẻ Jennett và Henry, những câu chuyện tuổi mộng mở vô cùng ngộ nghĩnh và đáng yêu.', -- Describe - nvarchar(100)
    N'STN_T012.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_TV001', -- ProductID - nvarchar(50)
    N'Em làm hoạ sĩ', -- NameBook - nvarchar(50)
    N'6', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Sách tập vẽ cho bé', -- Describe - nvarchar(100)
    N'STN_TV001.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_TV002', -- ProductID - nvarchar(50)
    N'Tôi vẽ', -- NameBook - nvarchar(50)
    N'6', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Sách tập vẽ nâng cao cho bé', -- Describe - nvarchar(100)
    N'STN_TV002.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_TV003', -- ProductID - nvarchar(50)
    N'Tập tô màu', -- NameBook - nvarchar(50)
    N'6', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Sách tập tô cơ bản cho bé', -- Describe - nvarchar(100)
    N'STN_TV003.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_TV004', -- ProductID - nvarchar(50)
    N'Tô màu bóc dán - Khu vườn', -- NameBook - nvarchar(50)
    N'6', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Sách tập vẽ cho bé', -- Describe - nvarchar(100)
    N'STN_TV004.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_TV005', -- ProductID - nvarchar(50)
    N'Bé tô màu - Khám phá thế giới xung quanh', -- NameBook - nvarchar(50)
    N'6', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Sách tập vẽ cho bé', -- Describe - nvarchar(100)
    N'STN_TV005.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_TV006', -- ProductID - nvarchar(50)
    N'Bé tập làm hoạ sĩ - Tô màu', -- NameBook - nvarchar(50)
    N'6', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Sách tập vẽ cho bé', -- Describe - nvarchar(100)
    N'STN_TV006.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_TV007', -- ProductID - nvarchar(50)
    N'Sách tô màu - Cầu nguyện', -- NameBook - nvarchar(50)
    N'6', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Sách tập vẽ cho bé', -- Describe - nvarchar(100)
    N'STN_TV007.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_TV008', -- ProductID - nvarchar(50)
    N'Vừa tô màu vừa học - Vật nuôi quanh em', -- NameBook - nvarchar(50)
    N'6', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Sách tập vẽ cho bé', -- Describe - nvarchar(100)
    N'STN_TV008.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_TV009', -- ProductID - nvarchar(50)
    N'Bé tô màu - Động vật sống dưới nước', -- NameBook - nvarchar(50)
    N'6', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Sách tập vẽ cho bé', -- Describe - nvarchar(100)
    N'STN_TV009.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_TV010', -- ProductID - nvarchar(50)
    N'Tập tô màu - Bảng chữ cái', -- NameBook - nvarchar(50)
    N'6', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Sách tập vẽ cho bé', -- Describe - nvarchar(100)
    N'STN_TV010.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_TV011', -- ProductID - nvarchar(50)
    N'Em tập tô màu - Động vật biển', -- NameBook - nvarchar(50)
    N'6', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Sách tập vẽ cho bé', -- Describe - nvarchar(100)
    N'STN_TV011.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'STN_TV012', -- ProductID - nvarchar(50)
    N'Tập tô màu và học chữ cái Tiếng Việt', -- NameBook - nvarchar(50)
    N'6', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    129000, -- Price - float
    100,   -- Amount - int
    N'Sách tập vẽ cho bé', -- Describe - nvarchar(100)
    N'STN_TV012.jpg', -- ImageID - nvarchar(50)
    N'1'  -- CategoryID - nvarchar(50)
    );
GO
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'SVH_001', -- ProductID - nvarchar(50)
    N'Hồng Lâu Mộng', -- NameBook - nvarchar(50)
    N'8', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    279000, -- Price - float
    100,   -- Amount - int
    N'Tiểu thuyết tình cảm Trung Quốc', -- Describe - nvarchar(1000)
    N'SVH_001', -- ImageID - nvarchar(50)
    N'2'  -- CategoryID - nvarchar(50)
    )
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'SVH_002', -- ProductID - nvarchar(50)
    N'Rừng Nauy', -- NameBook - nvarchar(50)
    N'8', -- WriterID - nvarchar(50)
    N'7', -- NxbID - nvarchar(50)
    279000, -- Price - float
    100,   -- Amount - int
    N'Tiểu thuyết trinh thám Nhật', -- Describe - nvarchar(1000)
    N'SVH_002', -- ImageID - nvarchar(50)
    N'2'  -- CategoryID - nvarchar(50)
    )
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'SVH_003', -- ProductID - nvarchar(50)
    N'13 Reasons Why', -- NameBook - nvarchar(50)
    N'9', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    279000, -- Price - float
    100,   -- Amount - int
    N'Nội dung của tiểu thuyết xoay quanh một học sinh trung học, Clay Jensen, và một học sinh khác, Hannah Baker, người đã tự tử sau khi phải chịu hàng loạt những sự việc khiến bản thân bị vũ nhục, gây ra bởi một số học snh khác tại trường của cô. Một hộp băng cassette do Hannah thu lại trước khi tự tử đã nói lên chi tiết về mười ba lý do tại sao cô muốn kết thúc cuộc đời mình.', -- Describe - nvarchar(1000)
    N'SVH_003', -- ImageID - nvarchar(50)
    N'2'  -- CategoryID - nvarchar(50)
    )
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'SVH_004', -- ProductID - nvarchar(50)
    N'Đồi gió hú', -- NameBook - nvarchar(50)
    N'10', -- WriterID - nvarchar(50)
    N'7', -- NxbID - nvarchar(50)
    279000, -- Price - float
    100,   -- Amount - int
    N'Đồi gió hú, câu chuyện cổ điển về tình yêu ngang trái và khát vọng chiếm hữu, cuốn tiểu thuyết dữ dội về Catherine Earnshaw.', -- Describe - nvarchar(1000)
    N'SVH_004', -- ImageID - nvarchar(50)
    N'2'  -- CategoryID - nvarchar(50)
    )
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'SVH_005', -- ProductID - nvarchar(50)
    N'David Copperfield', -- NameBook - nvarchar(50)
    N'11', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    279000, -- Price - float
    100,   -- Amount - int
    N'Câu chuyện theo dõi cuộc đời của David Copperfield từ thơ ấu cho đến trưởng thành. Các hồi ký cá nhân, cuộc phiêu lưu thám hiểm, trải nghiệm và quan sát của David Copperfield thời trẻ.', -- Describe - nvarchar(1000)
    N'SVH_005', -- ImageID - nvarchar(50)
    N'2'  -- CategoryID - nvarchar(50)
    )
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'SVH_006', -- ProductID - nvarchar(50)
    N'Bắt trẻ đồng xanh', -- NameBook - nvarchar(50)
    N'12', -- WriterID - nvarchar(50)
    N'7', -- NxbID - nvarchar(50)
    279000, -- Price - float
    100,   -- Amount - int
    N'Holden Caufield, 17 tuổi, đã từng bị đuổi học khỏi ba trường, và trường dự bi đại học Pencey Prep là ngôi trường thứ tư.', -- Describe - nvarchar(1000)
    N'SVH_006', -- ImageID - nvarchar(50)
    N'2'  -- CategoryID - nvarchar(50)
    )
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'SVH_007', -- ProductID - nvarchar(50)
    N'The great Gatsby', -- NameBook - nvarchar(50)
    N'13', -- WriterID - nvarchar(50)
    N'7', -- NxbID - nvarchar(50)
    279000, -- Price - float
    100,   -- Amount - int
    N'Tiểu thuyết The great Gatsby của nhà văn f. Scott Fitzgerald ghi lại tâm trạng mất mát chán chường, chiều hướng của những giấc mơ vàng của tuổi trẻ bị tan vỡ trong thất bại của "thời đại nhạc Jazz". Với giọng văn mỉa mai, trào lộng, ý nghĩa tinh tế, Fitzgerald đã thể hiện những suy ngẫm, những vấn dề của con người và thời đại mình.', -- Describe - nvarchar(1000)
    N'SVH_007', -- ImageID - nvarchar(50)
    N'2'  -- CategoryID - nvarchar(50)
    )
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'SVH_008', -- ProductID - nvarchar(50)
    N'Cuốn theo chiều gió', -- NameBook - nvarchar(50)
    N'14', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    279000, -- Price - float
    100,   -- Amount - int
    N'Tiểu thuyết tình cảm của Margaret Mitchell,  tác phẩm xoay quanh Scarlett O Hara, một cô gái miền Nam đầy sức mạnh, phải tìm mọi cách để sống sót qua chiến tranh và vượt lên cuộc sống khó khăn thời hậu chiến', -- Describe - nvarchar(1000)
    N'SVH_0008', -- ImageID - nvarchar(50)
    N'2'  -- CategoryID - nvarchar(50)
    )
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'SVH_009', -- ProductID - nvarchar(50)
    N'Tam Quốc Diễn Nghĩa', -- NameBook - nvarchar(50)
    N'15', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    279000, -- Price - float
    100,   -- Amount - int
    N'Tam Quốc Diễn Nghĩa, nguyên tên là Tam quốc chí thông tục diễn nghĩa, là một tiểu thuyết lịch sử Trung Quốc được La Quán Trung, viết vào thế kỷ 14, kể về thời kỳ hỗn loạn Tam Quốc với 120 chương hồi. Theo phương pháp bảy thực ba hư, tiểu thuyết này được xem là một trong Tứ đại danh tác của văn học Trung Quốc', -- Describe - nvarchar(1000)
    N'SVH_009', -- ImageID - nvarchar(50)
    N'2'  -- CategoryID - nvarchar(50)
    )
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'SVH_010', -- ProductID - nvarchar(50)
    N'The Graphs of Wrath', -- NameBook - nvarchar(50)
    N'16', -- WriterID - nvarchar(50)
    N'7', -- NxbID - nvarchar(50)
    279000, -- Price - float
    100,   -- Amount - int
    N'Tiểu thuyết The Graphs of Wrath hay Chùm nho uất hận phản ánh những biến đổi sâu sắc trong nông thôn nước Mỹ vào khoảng những năm đầu thế kỷ 20 dưới ảnh hưởng mạnh mẽ của thời đại công nghiệp hoá', -- Describe - nvarchar(1000)
    N'SVH_010', -- ImageID - nvarchar(50)
    N'2'  -- CategoryID - nvarchar(50)
    )
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'SVH_011', -- ProductID - nvarchar(50)
    N'the fault in our stars', -- NameBook - nvarchar(50)
    N'17', -- WriterID - nvarchar(50)
    N'6', -- NxbID - nvarchar(50)
    279000, -- Price - float
    100,   -- Amount - int
    N'Câu chuyện trong tiểu thuyết được kể bằng lời của một cô gái 16 tuổi, Hazel Grace Lancaster, mắc chứng bệnh ung thư và bị cha mẹ bắt phải tham gia một nhóm giúp đỡ, đây cũng là nơi cô gặp và yêu chàng trai Augustus Waters 17 tuổi,  một vận động viên bóng rổ trong quá khứ và phải đoạn chi để chữa bệnh.', -- Describe - nvarchar(1000)
    N'SVH_011', -- ImageID - nvarchar(50)
    N'2'  -- CategoryID - nvarchar(50)
    )
INSERT INTO dbo.Product
(
    ProductID,
    NameBook,
    WriterID,
    NxbID,
    Price,
    Amount,
    Describe,
    ImageID,
    CategoryID
)
VALUES
(   N'SVH_012', -- ProductID - nvarchar(50)
    N'Số đỏ', -- NameBook - nvarchar(50)
    N'18', -- WriterID - nvarchar(50)
    N'7', -- NxbID - nvarchar(50)
    279000, -- Price - float
    100,   -- Amount - int
    N'Tiểu thuyết xoay quanh nhân vật Xuân, biệt danh là Xuân tóc đỏ, từ chỗ bị coi là kẻ hạ lưu, bỗng nhảy lên tầng lớp danh giá của xã hội nhờ trào lưu Âu hoá của giới tiểu tư sản Hà Nội khi đó.', -- Describe - nvarchar(1000)
    N'SVH_012', -- ImageID - nvarchar(50)
    N'2'  -- CategoryID - nvarchar(50)
    )
---------------------INSERT WRITER--------------------------
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'1', -- WriterID - nvarchar(50)
    N'Eva Ibbotson'  -- WriterName - nvarchar(50)
    );

INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'2', -- WriterID - nvarchar(50)
    N'ONG-ART CHAICHARNCHEEP'  -- WriterName - nvarchar(50)
    );
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'3', -- WriterID - nvarchar(50)
    N'Nguyễn Thị Thanh Bình'  -- WriterName - nvarchar(50)
    );
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'4', -- WriterID - nvarchar(50)
    N'Tạ Duy Anh'  -- WriterName - nvarchar(50)
    );
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'5', -- WriterID - nvarchar(50)
    N'Kang Se-Hyoung'  -- WriterName - nvarchar(50)
    );
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'6', -- WriterID - nvarchar(50)
    N'Nhiều tác giả'  -- WriterName - nvarchar(50)
    );
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'7', -- WriterID - nvarchar(50)
    N'Masanobu Takashina'  -- WriterName - nvarchar(50)
    );
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'8', -- WriterID - nvarchar(50)
    N'Tào Tuyết Cần'  -- WriterName - nvarchar(50)
    )
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'9', -- WriterID - nvarchar(50)
    N'Haruki Murakami'  -- WriterName - nvarchar(50)
    )
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'10', -- WriterID - nvarchar(50)
    N'Jay Asher'  -- WriterName - nvarchar(50)
    )
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'11', -- WriterID - nvarchar(50)
    N'Emily Bronte'  -- WriterName - nvarchar(50)
    )
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'12', -- WriterID - nvarchar(50)
    N'David Copperfield'  -- WriterName - nvarchar(50)
    )
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'13', -- WriterID - nvarchar(50)
    N'J. D. Salinger'  -- WriterName - nvarchar(50)
    )
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'14', -- WriterID - nvarchar(50)
    N'F. Scott Fitzgerald'  -- WriterName - nvarchar(50)
    )
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'15', -- WriterID - nvarchar(50)
    N'Magaret Michell'  -- WriterName - nvarchar(50)
    )
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'16', -- WriterID - nvarchar(50)
    N'La Quán Trung'  -- WriterName - nvarchar(50)
    )
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'17', -- WriterID - nvarchar(50)
    N'John Strinbeck'  -- WriterName - nvarchar(50)
    )
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'18', -- WriterID - nvarchar(50)
    N'John Green'  -- WriterName - nvarchar(50)
    )
INSERT INTO dbo.Writer
(
    WriterID,
    WriterName
)
VALUES
(   N'19', -- WriterID - nvarchar(50)
    N'Vũ Trọng Phụng'  -- WriterName - nvarchar(50)
    )

--------------INSERT NXB------------
INSERT INTO dbo.Nxb
(
    NxbID,
    NxbName,
    NxbAddress
)
VALUES
(   N'1', -- NxbID - nvarchar(50)
    N'Irevan', -- NxbName - nvarchar(50)
    N'Russia'  -- NxbAddress - nvarchar(100)
    );
INSERT INTO dbo.Nxb
(
    NxbID,
    NxbName,
    NxbAddress
)
VALUES
(   N'1', -- NxbID - nvarchar(50)
    N'Irevan', -- NxbName - nvarchar(50)
    N'Russia'  -- NxbAddress - nvarchar(100)
    );
INSERT INTO dbo.Nxb
(
    NxbID,
    NxbName,
    NxbAddress
)
VALUES
(   N'2', -- NxbID - nvarchar(50)
    N'Nhà xuất bản Lao Động', -- NxbName - nvarchar(50)
    N'Việt Nam'  -- NxbAddress - nvarchar(100)
    );
INSERT INTO dbo.Nxb
(
    NxbID,
    NxbName,
    NxbAddress
)
VALUES
(   N'3', -- NxbID - nvarchar(50)
    N'Nhà xuất bản trẻ', -- NxbName - nvarchar(50)
    N'Việt Nam'  -- NxbAddress - nvarchar(100)
    );
INSERT INTO dbo.Nxb
(
    NxbID,
    NxbName,
    NxbAddress
)
VALUES
(   N'4', -- NxbID - nvarchar(50)
    N'Nhà xuất bản Phụ Nữ', -- NxbName - nvarchar(50)
    N'Việt Nam'  -- NxbAddress - nvarchar(100)
    );
INSERT INTO dbo.Nxb
(
    NxbID,
    NxbName,
    NxbAddress
)
VALUES
(   N'5', -- NxbID - nvarchar(50)
    N'Beyond the Cover', -- NxbName - nvarchar(50)
    N'Korea'  -- NxbAddress - nvarchar(100)
    );
INSERT INTO dbo.Nxb
(
    NxbID,
    NxbName,
    NxbAddress
)
VALUES
(   N'6', -- NxbID - nvarchar(50)
    N'Nhà xuất bản Kim Đồng', -- NxbName - nvarchar(50)
    N'Việt Nam'  -- NxbAddress - nvarchar(100)
    );
INSERT INTO dbo.Nxb
(
    NxbID,
    NxbName,
    NxbAddress
)
VALUES
(   N'7', -- NxbID - nvarchar(50)
    N'Nhà xuất bản Văn Học', -- NxbName - nvarchar(50)
    N'Việt Nam'  -- NxbAddress - nvarchar(100)
    );
 GO
  -------------INSERT CATEGORY---------------

  INSERT INTO dbo.Category
(
    CategoryID,
    CategoryName,
    Statuss
)
VALUES
(   N'STN', -- CategoryID - nvarchar(50)
    N'SachThieuNhi', -- CategoryName - nvarchar(50)
    NULL -- Statuss - bit
    )


GO 
