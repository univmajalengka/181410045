-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 03, 2020 at 07:08 PM
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
  `id_tamu` varchar(11) NOT NULL,
  `nama_tamu` varchar(20) DEFAULT NULL,
  `email_tamu` varchar(20) DEFAULT NULL,
  `url_tamu` varchar(30) DEFAULT NULL,
  `komentar_tamu` text,
  `tgl_tamu` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `buku_tamu`
--

INSERT INTO `buku_tamu` (`id_tamu`, `nama_tamu`, `email_tamu`, `url_tamu`, `komentar_tamu`, `tgl_tamu`) VALUES
('BKT0001', '32', '132', '45', '2', '2020-04-02'),
('BKT0002', 'supratman', 'su@xu.com', '', 'wew', '2020-04-03');

-- --------------------------------------------------------

--
-- Table structure for table `data_berita`
--

CREATE TABLE `data_berita` (
  `id_news` varchar(6) NOT NULL,
  `judul_berita` varchar(100) NOT NULL,
  `berita_isi` text NOT NULL,
  `pengirim_berita` varchar(30) NOT NULL,
  `jml_baca` int(6) NOT NULL,
  `tgl_publish` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_berita`
--

INSERT INTO `data_berita` (`id_news`, `judul_berita`, `berita_isi`, `pengirim_berita`, `jml_baca`, `tgl_publish`) VALUES
('NW0001', '3', 'a', '|', 0, '2020-04-03'),
('NW0002', 'e', 'w', '|', 0, '2020-04-03');

-- --------------------------------------------------------

--
-- Table structure for table `data_komentar`
--

CREATE TABLE `data_komentar` (
  `id_komentar` varchar(11) NOT NULL,
  `nama_komentar` varchar(20) DEFAULT NULL,
  `email_komentar` varchar(20) DEFAULT NULL,
  `url_komentar` varchar(30) DEFAULT NULL,
  `komentar_isi` text,
  `tgl_publish_k` date DEFAULT NULL,
  `jml_komentar` int(11) NOT NULL,
  `id_news` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_komentar`
--

INSERT INTO `data_komentar` (`id_komentar`, `nama_komentar`, `email_komentar`, `url_komentar`, `komentar_isi`, `tgl_publish_k`, `jml_komentar`, `id_news`) VALUES
('KMT0001', '123', '321', '321', '321', '2020-04-02', 0, 'NWS000'),
('KMT0002', '333', '333', '41234', '123123123', '2020-04-02', 0, 'NWS000'),
('KMT0003', '4', '4', '4', '4ee', '2020-04-03', 0, 'NW0002');

-- --------------------------------------------------------

--
-- Table structure for table `data_pengumuman`
--

CREATE TABLE `data_pengumuman` (
  `id_pengumuman` varchar(8) NOT NULL,
  `judul_pengumuman` varchar(100) NOT NULL,
  `isi_pengumuman` text,
  `pengirim_pengumuman` varchar(30) NOT NULL,
  `jml_baca` int(6) NOT NULL,
  `tgl_publish_p` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_pengumuman`
--

INSERT INTO `data_pengumuman` (`id_pengumuman`, `judul_pengumuman`, `isi_pengumuman`, `pengirim_pengumuman`, `jml_baca`, `tgl_publish_p`) VALUES
('PEG0001', '3', '13', '|', 0, '2020-04-03'),
('PEG0002', '3', '13', '|', 0, '2020-04-03'),
('PEG0003', '3', '13qwe', '|', 0, '2020-04-03'),
('PEG0004', '3', 'a', '|', 0, '2020-04-03');

-- --------------------------------------------------------

--
-- Table structure for table `data_potensi`
--

CREATE TABLE `data_potensi` (
  `id_potensi` varchar(8) NOT NULL,
  `nama_potensi` varchar(50) NOT NULL,
  `potensi_isi` text,
  `tgl_publish_po` date DEFAULT NULL,
  `username` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_potensi`
--

INSERT INTO `data_potensi` (`id_potensi`, `nama_potensi`, `potensi_isi`, `tgl_publish_po`, `username`) VALUES
('POT0001', 'BMKG', 'qweqwe', '2020-04-03', 'naverlyn'),
('POT0002', 'BMKG', 'e', '2020-04-03', 'naverlyn'),
('POT0003', 'BMKG', '23qwe23123', '2020-04-03', 'naverlyn'),
('POT0004', '34', 's', '2020-04-03', 'naverlyn'),
('POT0005', '43', 'w', '2020-04-03', '|');

-- --------------------------------------------------------

--
-- Table structure for table `data_profil`
--

CREATE TABLE `data_profil` (
  `id_profil` varchar(11) NOT NULL,
  `nama_profil` varchar(50) NOT NULL,
  `isi_profil` text NOT NULL,
  `username` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_profil`
--

INSERT INTO `data_profil` (`id_profil`, `nama_profil`, `isi_profil`, `username`) VALUES
('PRO0001', 'Aula', 'haid', 'naverlyn');

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
('d', 's', 'User', '33a'),
('naverlyn', 'asd', 'Admin', 'Y');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `buku_tamu`
--
ALTER TABLE `buku_tamu`
  ADD PRIMARY KEY (`id_tamu`);

--
-- Indexes for table `data_berita`
--
ALTER TABLE `data_berita`
  ADD PRIMARY KEY (`id_news`);

--
-- Indexes for table `data_komentar`
--
ALTER TABLE `data_komentar`
  ADD PRIMARY KEY (`id_komentar`);

--
-- Indexes for table `data_pengumuman`
--
ALTER TABLE `data_pengumuman`
  ADD PRIMARY KEY (`id_pengumuman`);

--
-- Indexes for table `data_potensi`
--
ALTER TABLE `data_potensi`
  ADD PRIMARY KEY (`id_potensi`);

--
-- Indexes for table `data_profil`
--
ALTER TABLE `data_profil`
  ADD PRIMARY KEY (`id_profil`);

--
-- Indexes for table `data_user`
--
ALTER TABLE `data_user`
  ADD PRIMARY KEY (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
