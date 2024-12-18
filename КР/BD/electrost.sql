PGDMP      9                |         	   electrost    17.2    17.2 5    �           0    0    ENCODING    ENCODING     !   SET client_encoding = 'WIN1251';
                           false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            �           1262    16545 	   electrost    DATABASE     }   CREATE DATABASE electrost WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE electrost;
                     postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
                     pg_database_owner    false            �           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                        pg_database_owner    false    4            �            1259    16588 	   inventory    TABLE     �   CREATE TABLE public.inventory (
    inventory_id integer NOT NULL,
    product_id integer,
    quantity integer NOT NULL,
    date_received date NOT NULL,
    premises_id integer
);
    DROP TABLE public.inventory;
       public         heap r       postgres    false    4            �            1259    16587    inventory_inventory_id_seq    SEQUENCE     �   CREATE SEQUENCE public.inventory_inventory_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.inventory_inventory_id_seq;
       public               postgres    false    4    226            �           0    0    inventory_inventory_id_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.inventory_inventory_id_seq OWNED BY public.inventory.inventory_id;
          public               postgres    false    225            �            1259    16565    managers    TABLE     �   CREATE TABLE public.managers (
    manager_id integer NOT NULL,
    name character varying(255) NOT NULL,
    "position" character varying(255) NOT NULL
);
    DROP TABLE public.managers;
       public         heap r       postgres    false    4            �            1259    16564    managers_manager_id_seq    SEQUENCE     �   CREATE SEQUENCE public.managers_manager_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.managers_manager_id_seq;
       public               postgres    false    222    4            �           0    0    managers_manager_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.managers_manager_id_seq OWNED BY public.managers.manager_id;
          public               postgres    false    221            �            1259    16547    premises    TABLE     �   CREATE TABLE public.premises (
    premises_id integer NOT NULL,
    name character varying(255) NOT NULL,
    address character varying(255) NOT NULL
);
    DROP TABLE public.premises;
       public         heap r       postgres    false    4            �            1259    16546    premises_premises_id_seq    SEQUENCE     �   CREATE SEQUENCE public.premises_premises_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.premises_premises_id_seq;
       public               postgres    false    4    218            �           0    0    premises_premises_id_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.premises_premises_id_seq OWNED BY public.premises.premises_id;
          public               postgres    false    217            �            1259    16574    products    TABLE     �   CREATE TABLE public.products (
    product_id integer NOT NULL,
    description text NOT NULL,
    supplier_id integer,
    image bytea
);
    DROP TABLE public.products;
       public         heap r       postgres    false    4            �            1259    16573    products_product_id_seq    SEQUENCE     �   CREATE SEQUENCE public.products_product_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.products_product_id_seq;
       public               postgres    false    224    4            �           0    0    products_product_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.products_product_id_seq OWNED BY public.products.product_id;
          public               postgres    false    223            �            1259    16605    sales    TABLE     �   CREATE TABLE public.sales (
    sale_id integer NOT NULL,
    product_id integer,
    quantity integer NOT NULL,
    sale_date date NOT NULL,
    sale_price numeric(10,2) NOT NULL,
    manager_id integer
);
    DROP TABLE public.sales;
       public         heap r       postgres    false    4            �            1259    16604    sales_sale_id_seq    SEQUENCE     �   CREATE SEQUENCE public.sales_sale_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.sales_sale_id_seq;
       public               postgres    false    228    4            �           0    0    sales_sale_id_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.sales_sale_id_seq OWNED BY public.sales.sale_id;
          public               postgres    false    227            �            1259    16556 	   suppliers    TABLE     �   CREATE TABLE public.suppliers (
    supplier_id integer NOT NULL,
    name character varying(255) NOT NULL,
    address character varying(255) NOT NULL
);
    DROP TABLE public.suppliers;
       public         heap r       postgres    false    4            �            1259    16555    suppliers_supplier_id_seq    SEQUENCE     �   CREATE SEQUENCE public.suppliers_supplier_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public.suppliers_supplier_id_seq;
       public               postgres    false    220    4            �           0    0    suppliers_supplier_id_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public.suppliers_supplier_id_seq OWNED BY public.suppliers.supplier_id;
          public               postgres    false    219            >           2604    16591    inventory inventory_id    DEFAULT     �   ALTER TABLE ONLY public.inventory ALTER COLUMN inventory_id SET DEFAULT nextval('public.inventory_inventory_id_seq'::regclass);
 E   ALTER TABLE public.inventory ALTER COLUMN inventory_id DROP DEFAULT;
       public               postgres    false    226    225    226            <           2604    16568    managers manager_id    DEFAULT     z   ALTER TABLE ONLY public.managers ALTER COLUMN manager_id SET DEFAULT nextval('public.managers_manager_id_seq'::regclass);
 B   ALTER TABLE public.managers ALTER COLUMN manager_id DROP DEFAULT;
       public               postgres    false    221    222    222            :           2604    16550    premises premises_id    DEFAULT     |   ALTER TABLE ONLY public.premises ALTER COLUMN premises_id SET DEFAULT nextval('public.premises_premises_id_seq'::regclass);
 C   ALTER TABLE public.premises ALTER COLUMN premises_id DROP DEFAULT;
       public               postgres    false    218    217    218            =           2604    16577    products product_id    DEFAULT     z   ALTER TABLE ONLY public.products ALTER COLUMN product_id SET DEFAULT nextval('public.products_product_id_seq'::regclass);
 B   ALTER TABLE public.products ALTER COLUMN product_id DROP DEFAULT;
       public               postgres    false    223    224    224            ?           2604    16608    sales sale_id    DEFAULT     n   ALTER TABLE ONLY public.sales ALTER COLUMN sale_id SET DEFAULT nextval('public.sales_sale_id_seq'::regclass);
 <   ALTER TABLE public.sales ALTER COLUMN sale_id DROP DEFAULT;
       public               postgres    false    228    227    228            ;           2604    16559    suppliers supplier_id    DEFAULT     ~   ALTER TABLE ONLY public.suppliers ALTER COLUMN supplier_id SET DEFAULT nextval('public.suppliers_supplier_id_seq'::regclass);
 D   ALTER TABLE public.suppliers ALTER COLUMN supplier_id DROP DEFAULT;
       public               postgres    false    219    220    220            �          0    16588 	   inventory 
   TABLE DATA           c   COPY public.inventory (inventory_id, product_id, quantity, date_received, premises_id) FROM stdin;
    public               postgres    false    226   6=       �          0    16565    managers 
   TABLE DATA           @   COPY public.managers (manager_id, name, "position") FROM stdin;
    public               postgres    false    222   S=       �          0    16547    premises 
   TABLE DATA           >   COPY public.premises (premises_id, name, address) FROM stdin;
    public               postgres    false    218   p=       �          0    16574    products 
   TABLE DATA           O   COPY public.products (product_id, description, supplier_id, image) FROM stdin;
    public               postgres    false    224   �=       �          0    16605    sales 
   TABLE DATA           a   COPY public.sales (sale_id, product_id, quantity, sale_date, sale_price, manager_id) FROM stdin;
    public               postgres    false    228   �=       �          0    16556 	   suppliers 
   TABLE DATA           ?   COPY public.suppliers (supplier_id, name, address) FROM stdin;
    public               postgres    false    220   >       �           0    0    inventory_inventory_id_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.inventory_inventory_id_seq', 1, false);
          public               postgres    false    225            �           0    0    managers_manager_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.managers_manager_id_seq', 1, false);
          public               postgres    false    221            �           0    0    premises_premises_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.premises_premises_id_seq', 2, true);
          public               postgres    false    217            �           0    0    products_product_id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.products_product_id_seq', 5, true);
          public               postgres    false    223            �           0    0    sales_sale_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.sales_sale_id_seq', 1, false);
          public               postgres    false    227                        0    0    suppliers_supplier_id_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.suppliers_supplier_id_seq', 1, true);
          public               postgres    false    219            I           2606    16593    inventory inventory_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.inventory
    ADD CONSTRAINT inventory_pkey PRIMARY KEY (inventory_id);
 B   ALTER TABLE ONLY public.inventory DROP CONSTRAINT inventory_pkey;
       public                 postgres    false    226            E           2606    16572    managers managers_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.managers
    ADD CONSTRAINT managers_pkey PRIMARY KEY (manager_id);
 @   ALTER TABLE ONLY public.managers DROP CONSTRAINT managers_pkey;
       public                 postgres    false    222            A           2606    16554    premises premises_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.premises
    ADD CONSTRAINT premises_pkey PRIMARY KEY (premises_id);
 @   ALTER TABLE ONLY public.premises DROP CONSTRAINT premises_pkey;
       public                 postgres    false    218            G           2606    16581    products products_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_pkey PRIMARY KEY (product_id);
 @   ALTER TABLE ONLY public.products DROP CONSTRAINT products_pkey;
       public                 postgres    false    224            K           2606    16610    sales sales_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.sales
    ADD CONSTRAINT sales_pkey PRIMARY KEY (sale_id);
 :   ALTER TABLE ONLY public.sales DROP CONSTRAINT sales_pkey;
       public                 postgres    false    228            C           2606    16563    suppliers suppliers_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.suppliers
    ADD CONSTRAINT suppliers_pkey PRIMARY KEY (supplier_id);
 B   ALTER TABLE ONLY public.suppliers DROP CONSTRAINT suppliers_pkey;
       public                 postgres    false    220            M           2606    16599 $   inventory inventory_premises_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.inventory
    ADD CONSTRAINT inventory_premises_id_fkey FOREIGN KEY (premises_id) REFERENCES public.premises(premises_id);
 N   ALTER TABLE ONLY public.inventory DROP CONSTRAINT inventory_premises_id_fkey;
       public               postgres    false    4673    218    226            N           2606    16594 #   inventory inventory_product_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.inventory
    ADD CONSTRAINT inventory_product_id_fkey FOREIGN KEY (product_id) REFERENCES public.products(product_id);
 M   ALTER TABLE ONLY public.inventory DROP CONSTRAINT inventory_product_id_fkey;
       public               postgres    false    4679    224    226            L           2606    16582 "   products products_supplier_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.products
    ADD CONSTRAINT products_supplier_id_fkey FOREIGN KEY (supplier_id) REFERENCES public.suppliers(supplier_id);
 L   ALTER TABLE ONLY public.products DROP CONSTRAINT products_supplier_id_fkey;
       public               postgres    false    224    220    4675            O           2606    16616    sales sales_manager_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.sales
    ADD CONSTRAINT sales_manager_id_fkey FOREIGN KEY (manager_id) REFERENCES public.managers(manager_id);
 E   ALTER TABLE ONLY public.sales DROP CONSTRAINT sales_manager_id_fkey;
       public               postgres    false    222    4677    228            P           2606    16611    sales sales_product_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.sales
    ADD CONSTRAINT sales_product_id_fkey FOREIGN KEY (product_id) REFERENCES public.products(product_id);
 E   ALTER TABLE ONLY public.sales DROP CONSTRAINT sales_product_id_fkey;
       public               postgres    false    224    4679    228            �      x������ � �      �      x������ � �      �   I   x�3�����w�~�Tx��5�c=�3�?�{����ޙw_�{��Ճ�
O�"�F
\F�_�~��2c�=... �K8�      �      x������ � �      �      x������ � �      �   ?   x�4 ��1	Xiaomi Russia	�.����������� ��.������ ��� 61
\.


�t�     