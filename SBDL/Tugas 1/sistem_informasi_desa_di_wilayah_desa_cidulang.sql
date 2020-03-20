-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 20, 2020 at 05:08 AM
-- Server version: 10.1.39-MariaDB
-- PHP Version: 7.1.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sistem_informasi_desa_di_wilayah_desa_cidulang`
--

-- --------------------------------------------------------

--
-- Table structure for table `buku_tamu`
--

CREATE TABLE `buku_tamu` (
  `id` int(11) NOT NULL,
  `nama` varchar(20) DEFAULT NULL,
  `email` varchar(20) DEFAULT NULL,
  `url` varchar(30) DEFAULT NULL,
  `komentar` text,
  `tgl` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `buku_tamu`
--

INSERT INTO `buku_tamu` (`id`, `nama`, `email`, `url`, `komentar`, `tgl`) VALUES
(1, 'Samsudin', 'samsudin69@gmail.com', 'samsudin.com', 'njir bro', '2020-03-20');

-- --------------------------------------------------------

--
-- Table structure for table `data_berita`
--

CREATE TABLE `data_berita` (
  `id_news` int(5) NOT NULL,
  `judul` varchar(100) NOT NULL,
  `berita` text NOT NULL,
  `pengirim` varchar(30) NOT NULL,
  `jml_baca` int(6) NOT NULL,
  `tgl` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_berita`
--

INSERT INTO `data_berita` (`id_news`, `judul`, `berita`, `pengirim`, `jml_baca`, `tgl`) VALUES
(1, 'njir mabar', 'welp', 'User', 69, '2020-03-19');

-- --------------------------------------------------------

--
-- Table structure for table `data_komentar`
--

CREATE TABLE `data_komentar` (
  `id` int(11) NOT NULL,
  `nama` varchar(20) DEFAULT NULL,
  `email` varchar(20) DEFAULT NULL,
  `url` varchar(30) DEFAULT NULL,
  `komentar` text,
  `tgl` date DEFAULT NULL,
  `jml_komen` int(11) NOT NULL,
  `id_news` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_komentar`
--

INSERT INTO `data_komentar` (`id`, `nama`, `email`, `url`, `komentar`, `tgl`, `jml_komen`, `id_news`) VALUES
(1, 'Samsudin', 'samsudin69@gmail.com', 'samsudin.com', 'wuih gila lo', '2020-03-21', 4, 1);

-- --------------------------------------------------------

--
-- Table structure for table `data_pengumuman`
--

CREATE TABLE `data_pengumuman` (
  `id` int(5) NOT NULL,
  `judul` varchar(100) NOT NULL,
  `isi` text,
  `pengirim` varchar(30) NOT NULL,
  `jml_baca` int(6) NOT NULL,
  `tgl` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_pengumuman`
--

INSERT INTO `data_pengumuman` (`id`, `judul`, `isi`, `pengirim`, `jml_baca`, `tgl`) VALUES
(1, 'BMKG', '????????', 'naverlyn', 69, '2020-03-22');

-- --------------------------------------------------------

--
-- Table structure for table `data_potensi`
--

CREATE TABLE `data_potensi` (
  `id` int(5) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `potensi` text,
  `tgl` date DEFAULT NULL,
  `username` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_potensi`
--

INSERT INTO `data_potensi` (`id`, `nama`, `potensi`, `tgl`, `username`) VALUES
(1, 'naverlyn', 'https://www.youtube.com/watch?v=dQw4w9WgXcQ', '2020-03-23', 'naverlyn');

-- --------------------------------------------------------

--
-- Table structure for table `data_profil`
--

CREATE TABLE `data_profil` (
  `id_profil` int(11) NOT NULL,
  `nama_profil` varchar(50) NOT NULL,
  `isi_profil` text NOT NULL,
  `username` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_profil`
--

INSERT INTO `data_profil` (`id_profil`, `nama_profil`, `isi_profil`, `username`) VALUES
(1, 'naverlyn', 'hi', 'naverlyn');

-- --------------------------------------------------------

--
-- Table structure for table `data_user`
--

CREATE TABLE `data_user` (
  `username` varchar(30) NOT NULL,
  `password` varchar(32) DEFAULT NULL,
  `level` varchar(10) DEFAULT NULL,
  `nama_lengkap` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_user`
--

INSERT INTO `data_user` (`username`, `password`, `level`, `nama_lengkap`) VALUES
('naverlyn', 'oakwoakwoakwoakw', 'Admin', 'Y');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `buku_tamu`
--
ALTER TABLE `buku_tamu`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nama` (`nama`);

--
-- Indexes for table `data_berita`
--
ALTER TABLE `data_berita`
  ADD PRIMARY KEY (`id_news`);

--
-- Indexes for table `data_komentar`
--
ALTER TABLE `data_komentar`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_news` (`id_news`),
  ADD KEY `nama` (`nama`);

--
-- Indexes for table `data_pengumuman`
--
ALTER TABLE `data_pengumuman`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `data_potensi`
--
ALTER TABLE `data_potensi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `username` (`username`);

--
-- Indexes for table `data_profil`
--
ALTER TABLE `data_profil`
  ADD PRIMARY KEY (`id_profil`),
  ADD KEY `username` (`username`);

--
-- Indexes for table `data_user`
--
ALTER TABLE `data_user`
  ADD PRIMARY KEY (`username`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `data_komentar`
--
ALTER TABLE `data_komentar`
  ADD CONSTRAINT `data_komentar_ibfk_1` FOREIGN KEY (`id`) REFERENCES `buku_tamu` (`id`),
  ADD CONSTRAINT `data_komentar_ibfk_2` FOREIGN KEY (`id_news`) REFERENCES `data_berita` (`id_news`),
  ADD CONSTRAINT `data_komentar_ibfk_3` FOREIGN KEY (`nama`) REFERENCES `buku_tamu` (`nama`);

--
-- Constraints for table `data_potensi`
--
ALTER TABLE `data_potensi`
  ADD CONSTRAINT `data_potensi_ibfk_1` FOREIGN KEY (`id`) REFERENCES `data_pengumuman` (`id`),
  ADD CONSTRAINT `data_potensi_ibfk_2` FOREIGN KEY (`username`) REFERENCES `data_profil` (`username`);

--
-- Constraints for table `data_profil`
--
ALTER TABLE `data_profil`
  ADD CONSTRAINT `data_profil_ibfk_1` FOREIGN KEY (`username`) REFERENCES `data_user` (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
